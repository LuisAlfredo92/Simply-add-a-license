namespace Simply_add_a_license.Commands
{
    partial class SimplyAddALicenseWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimplyAddALicenseWindow));
            this.licensesListView = new System.Windows.Forms.ListView();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.AboutPictureBox = new System.Windows.Forms.PictureBox();
            this.aboutLicensebutton = new System.Windows.Forms.Button();
            this.addLicensebutton = new System.Windows.Forms.Button();
            this.licenseTextBox = new System.Windows.Forms.TextBox();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AboutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // licensesListView
            // 
            this.licensesListView.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.licensesListView, "licensesListView");
            this.licensesListView.FullRowSelect = true;
            this.licensesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.licensesListView.HideSelection = false;
            this.licensesListView.MultiSelect = false;
            this.licensesListView.Name = "licensesListView";
            this.licensesListView.UseCompatibleStateImageBehavior = false;
            this.licensesListView.View = System.Windows.Forms.View.Tile;
            this.licensesListView.SelectedIndexChanged += new System.EventHandler(this.LicensesListView_SelectedIndexChanged);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.AboutPictureBox);
            this.buttonsPanel.Controls.Add(this.aboutLicensebutton);
            this.buttonsPanel.Controls.Add(this.addLicensebutton);
            resources.ApplyResources(this.buttonsPanel, "buttonsPanel");
            this.buttonsPanel.Name = "buttonsPanel";
            // 
            // AboutPictureBox
            // 
            this.AboutPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.AboutPictureBox, "AboutPictureBox");
            this.AboutPictureBox.Image = global::Simply_add_a_license.Properties.Resources.Simply_add_a_license_icon_32x32;
            this.AboutPictureBox.Name = "AboutPictureBox";
            this.AboutPictureBox.TabStop = false;
            this.AboutPictureBox.Click += new System.EventHandler(this.AboutPictureBox_Click);
            // 
            // aboutLicensebutton
            // 
            resources.ApplyResources(this.aboutLicensebutton, "aboutLicensebutton");
            this.aboutLicensebutton.Name = "aboutLicensebutton";
            this.aboutLicensebutton.UseVisualStyleBackColor = true;
            this.aboutLicensebutton.Click += new System.EventHandler(this.MoreInfobutton_Click);
            // 
            // addLicensebutton
            // 
            resources.ApplyResources(this.addLicensebutton, "addLicensebutton");
            this.addLicensebutton.Name = "addLicensebutton";
            this.addLicensebutton.UseVisualStyleBackColor = true;
            this.addLicensebutton.Click += new System.EventHandler(this.addLicensebutton_Click);
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.licenseTextBox, "licenseTextBox");
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.ReadOnly = true;
            // 
            // SimplyAddALicenseWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.licenseTextBox);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.licensesListView);
            this.Name = "SimplyAddALicenseWindow";
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AboutPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView licensesListView;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button aboutLicensebutton;
        private System.Windows.Forms.Button addLicensebutton;
        private System.Windows.Forms.TextBox licenseTextBox;
        private System.Windows.Forms.PictureBox AboutPictureBox;
    }
}