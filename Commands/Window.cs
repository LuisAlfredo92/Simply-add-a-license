﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Simply_add_a_license.Commands
{
    /// <summary>
    /// The window that will show the licenses in a list where te user can
    /// select one of them and then it will be displayed on the right
    /// controls.
    /// </summary>
    public partial class SimplyAddALicenseWindow : Form
    {
        private readonly List<License> licenses = new List<License>();
        private License selectedLicense;
        /// <summary>
        /// Gets or Sets the solution licenseFilePath.
        /// </summary>
        public DirectoryInfo Solutionpath { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplyAddALicenseWindow"/> class and reads
        /// all the licenses info from "Licenses" folder
        /// </summary>
        public SimplyAddALicenseWindow()
        {
            InitializeComponent();

            licensesListView.BeginUpdate();
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location,
                execPath = Path.GetDirectoryName(executable),
                licensesPath = Path.Combine(execPath, "Resources", "Licenses", "details");
            foreach (var file in Directory.GetFiles(licensesPath))
            {
                // Read JSON from each file
                JObject fullJson = JObject.Parse(File.ReadAllText(file));

                /* Since some licenses don't have URLs to get more information, first we check 
                 * if they have an opensource.org URL to use it, if not, we get the first URL
                 * they have, and if they don't have any URL, then we add it as an empty string
                 */
                var moreInfoLinks = fullJson["seeAlso"].Where(url => url.ToString().Contains("opensource.org"));
                string link;
                if (!moreInfoLinks.Any())
                {
                    var aux = fullJson["seeAlso"].ToArray();
                    link = aux.Length != 0 ? aux[0].ToString() : null;
                }
                else
                    link = moreInfoLinks.First().ToString();

                // Create the license
                licenses.Add(new License(
                    fullJson["licenseId"].ToString(),
                    fullJson["name"].ToString(),
                    fullJson["licenseText"].ToString(),
                    link
                    ));
            }

            //Create groups of list view
            var recommendedGroup = new ListViewGroup("Recommended licenses", HorizontalAlignment.Center);
            var allLicencesGroup = new ListViewGroup("All licenses", HorizontalAlignment.Center);
            licensesListView.Groups.Add(recommendedGroup);
            licensesListView.Groups.Add(allLicencesGroup);

            // Add recommended licenses
            foreach (var license in licenses.Where(license => (new string[] { "GPL-3.0-or-later", "MIT", "Apache-2.0" }).Contains(license.LicenseId)).ToList())
                licensesListView.Items.Add(new ListViewItem(license.FullName, recommendedGroup));

            // Add all licenses
            foreach (var license in licenses)
                licensesListView.Items.Add(new ListViewItem(license.FullName, allLicencesGroup));

            licensesListView.EndUpdate();
        }

        /// <summary>
        /// Function that will be executed when you click the "More info" button on the main window
        /// </summary>
        private void MoreInfobutton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(selectedLicense.MoreInfoLink);
        }

        /// <summary>
        /// Function that will be executed when you select an item at the licenses ListView
        /// </summary>
        private void LicensesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (sender as ListView).FocusedItem;
            // Sometimes the control returns null before returning the real selected item.
            // This validates that
            if (selectedItem is null) return;

            // Gets the ID of the selected license and replaces the licenseTextBox text with the license text
            string selectedText = selectedItem.Text,
                selectedId = selectedText.Substring(selectedText.IndexOf('(') + 1, selectedText.IndexOf(')') - 1);
            selectedLicense = licenses.Where(lic => lic.LicenseId == selectedId).ToArray()[0];
            licenseTextBox.Text = selectedLicense.Text.Replace("\n", "\r\n");

            // Activate buttons
            moreInfobutton.Enabled = true;
            addLicensebutton.Enabled = true;
        }

        /// <summary>
        /// Function that will be excecuted when clicking on "Add license" button
        /// </summary>
        private void addLicensebutton_Click(object sender, EventArgs e)
        {
            // First we get both paths (License file and csproj)
            bool? overwrite = null;
            string licenseFilePath = Path.Combine(Solutionpath.FullName, "LICENSE");
            string csprojFilePath = Directory.GetFiles(Solutionpath.FullName)
                .Where(value => value.Contains("csproj"))
                .First();

            // And whe check that there isn't an existing license already
            if (File.Exists(licenseFilePath) || File.ReadAllText(csprojFilePath).Contains("LICENSE"))
            {
                overwrite = MessageBox.Show(
                    "A license already exists. Overwrite?",
                    "Overwrite license?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes;

                if (!overwrite.Value)
                    return;

                File.Delete(licenseFilePath);
            }

            // Then the writing process begin
            File.WriteAllText(licenseFilePath, selectedLicense.Text);

            #region Add the LICENSE file to csproj file so it'll appear on the Solution explorer
            if (!overwrite.HasValue)
            {
                // We create the XML node we'll add
                XElement licenseNode = new XElement("Content");
                licenseNode.SetAttributeValue("Include", "LICENSE");
                licenseNode.Add(new XElement("CopyToOutputDirectory", "Always"));
                licenseNode.Add(new XElement("IncludeInVSIX", "true"));

                // Finally we add the new node to the csproj
                XElement csprojXML = XElement.Load(csprojFilePath);
                var itemGroups = csprojXML.Descendants()
                    .Where(des => des.Name.LocalName.Equals("ItemGroup"))
                    .ToList();
                if (itemGroups.Any())
                    itemGroups[itemGroups.Count - 1].Add(licenseNode);
                else
                {
                    XElement itemGroup = new XElement("ItemGroup");
                    itemGroup.Add(licenseNode);
                    csprojXML.Add(itemGroup);
                }
                csprojXML.Save(csprojFilePath);
            }
            #endregion
            Close();
            Dispose();
        }
    }
}
