using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Simply_add_a_license.Commands
{
    /// <summary>
    /// Window that contains all the information about credits and authors
    /// </summary>
    public partial class About : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="About"/> window.
        /// </summary>
        public About()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the repository on GitHub
        /// </summary>
        private void GoToRepository() => Process.Start("https://github.com/LuisAlfredo92/Simply-add-a-license");

        /// <summary>
        /// Opens my GitHub profile
        /// </summary>
        private void GoToMyGitHub() => Process.Start("https://github.com/LuisAlfredo92");

        /// <summary>
        /// Funtion executed when clicking the title iamge
        /// </summary>
        private void TitlePictureBox_Click(object sender, EventArgs e) => GoToRepository();

        /// <summary>
        /// Funtion executed when clicking the github link label
        /// </summary>
        private void GithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => GoToRepository();

        /// <summary>
        /// Funtion executed when clicking the symbol image
        /// </summary>
        private void SymbolPictureBox_Click(object sender, EventArgs e) => GoToMyGitHub();

        /// <summary>
        /// Funtion executed when clicking the github profile link label
        /// </summary>
        private void MyGitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => GoToMyGitHub();

        /// <summary>
        /// Funtion executed when clicking the licenses link label
        /// </summary>
        private void LicensesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/spdx/license-list-data");

        /// <summary>
        /// Funtion executed when clicking The Linux Foundation link label
        /// </summary>
        private void TLFLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://www.linuxfoundation.org/");

        /// <summary>
        /// Funtion executed when clicking the Apache license link label
        /// </summary>
        private void ApacheLicenseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location,
                execPath = Path.GetDirectoryName(executable),
                licensesPath = Path.Combine(execPath, "Commands", "Resources", "External licenses", "Apache 2.0 License.txt");
            Process.Start(licensesPath);
        }

        /// <summary>
        /// Funtion executed when clicking the Choose a license link label
        /// </summary>
        private void ChooseALicenseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://choosealicense.com/");

        /// <summary>
        /// Funtion executed when clicking the CC BY 3.0 link label
        /// </summary>
        private void CCBY3LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://creativecommons.org/licenses/by/3.0/");

        /// <summary>
        /// Funtion executed when clicking the Envdte100 title link label
        /// </summary>
        private void Envdte100LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://www.nuget.org/packages/envdte100/17.2.32505.113");

        /// <summary>
        /// Funtion executed when clicking the MSLT license link label
        /// </summary>
        private void MSLTLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://www.nuget.org/packages/envdte100/17.2.32505.113/license");


    }
}
