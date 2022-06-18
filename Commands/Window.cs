using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
        private string moreInfoURL;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplyAddALicenseWindow"/> class and reads
        /// all the licenses info from "Licenses" folder
        /// </summary>
        public SimplyAddALicenseWindow()
        {
            InitializeComponent();

            licensesListView.BeginUpdate();
            moreInfoURL = string.Empty;
            foreach (var file in Directory.GetFiles(@"Resources/Licenses/details/"))
            {
                // Read JSON from each file
                JObject fullJson = JObject.Parse(File.ReadAllText(file));

                /* Since some licenses don't have URLs to get more information, first we check 
                 * if they have an opensource.org URL to use it, if not, we get the first URL
                 * they have, and if they don't have any URL, then we add it as an empty string
                 */
                var moreInfoLinks = fullJson["seeAlso"].Where(url => url.ToString().Contains("opensource.org")).ToArray();
                string link;
                if (moreInfoLinks.Length == 0)
                {
                    var aux = fullJson["seeAlso"].ToArray();
                    link = aux.Length != 0 ? aux[0].ToString() : null;
                }
                else
                    link = moreInfoLinks.ToArray()[0].ToString();

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
            System.Diagnostics.Process.Start(moreInfoURL);
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
            License licReceived = licenses.Where(lic => lic.LicenseId == selectedId).ToArray()[0];
            licenseTextBox.Text = licReceived.Text.Replace("\n", "\r\n");

            // Activate buttons
            moreInfoURL = licReceived.MoreInfoLink;
            moreInfobutton.Enabled = true;
            addLicensebutton.Enabled = true;
        }
    }
}
