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
    /// The window that will show the licences in a list where te user can
    /// select one of them and then it will be displayed on the right
    /// controls.
    /// </summary>
    public partial class SimplyAddALicenseWindow : Form
    {
        private readonly List<License> licences = new List<License>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplyAddALicenseWindow"/> class and reads
        /// all the licences info from "Licenses" folder
        /// </summary>
        public SimplyAddALicenseWindow()
        {
            InitializeComponent();

            licensesListView.BeginUpdate();
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
                licences.Add(new License(
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
            foreach (var license in licences.Where(license => (new string[] { "GPL-3.0-or-later", "MIT", "Apache-2.0" }).Contains(license.LicenseId)).ToList())
                licensesListView.Items.Add(new ListViewItem(license.FullName, recommendedGroup));

            // Add all licenses
            foreach (var license in licences)
                licensesListView.Items.Add(new ListViewItem(license.FullName, allLicencesGroup));

            licensesListView.EndUpdate();
        }

        /// <summary>
        /// Function that will be executed when you click the "More info" button on the main window
        /// </summary>
        private void MoreInfobutton_Click(object sender, EventArgs e)
        {
            // TODO: Redirect to the link on the json
        }

        /// <summary>
        /// Function that will be executed when you select an item at the licenses ListView
        /// </summary>
        private void LicensesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
