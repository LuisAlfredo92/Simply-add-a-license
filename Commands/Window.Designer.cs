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
            this.moreInfobutton = new System.Windows.Forms.Button();
            this.addLicensebutton = new System.Windows.Forms.Button();
            this.licenseTextBox = new System.Windows.Forms.TextBox();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // licensesListView
            // 
            this.licensesListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.licensesListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.licensesListView.FullRowSelect = true;
            this.licensesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.licensesListView.HideSelection = false;
            this.licensesListView.Location = new System.Drawing.Point(0, 0);
            this.licensesListView.MultiSelect = false;
            this.licensesListView.Name = "licensesListView";
            this.licensesListView.Size = new System.Drawing.Size(200, 450);
            this.licensesListView.TabIndex = 0;
            this.licensesListView.UseCompatibleStateImageBehavior = false;
            this.licensesListView.View = System.Windows.Forms.View.Tile;
            this.licensesListView.SelectedIndexChanged += new System.EventHandler(this.LicensesListView_SelectedIndexChanged);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.moreInfobutton);
            this.buttonsPanel.Controls.Add(this.addLicensebutton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(200, 418);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(600, 32);
            this.buttonsPanel.TabIndex = 1;
            // 
            // moreInfobutton
            // 
            this.moreInfobutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moreInfobutton.Enabled = false;
            this.moreInfobutton.Location = new System.Drawing.Point(0, 0);
            this.moreInfobutton.Name = "moreInfobutton";
            this.moreInfobutton.Size = new System.Drawing.Size(300, 32);
            this.moreInfobutton.TabIndex = 1;
            this.moreInfobutton.Text = "More info";
            this.moreInfobutton.UseVisualStyleBackColor = true;
            this.moreInfobutton.Click += new System.EventHandler(this.MoreInfobutton_Click);
            // 
            // addLicensebutton
            // 
            this.addLicensebutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addLicensebutton.Enabled = false;
            this.addLicensebutton.Location = new System.Drawing.Point(300, 0);
            this.addLicensebutton.Name = "addLicensebutton";
            this.addLicensebutton.Size = new System.Drawing.Size(300, 32);
            this.addLicensebutton.TabIndex = 0;
            this.addLicensebutton.Text = "Add license";
            this.addLicensebutton.UseVisualStyleBackColor = true;
            this.addLicensebutton.Click += new System.EventHandler(this.addLicensebutton_Click);
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.licenseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licenseTextBox.Location = new System.Drawing.Point(200, 0);
            this.licenseTextBox.Multiline = true;
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.ReadOnly = true;
            this.licenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.licenseTextBox.Size = new System.Drawing.Size(600, 418);
            this.licenseTextBox.TabIndex = 2;
            this.licenseTextBox.Text = "🢀 Select a license from the list at left";
            // 
            // SimplyAddALicenseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.licenseTextBox);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.licensesListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimplyAddALicenseWindow";
            this.Text = "Simply add a license";
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView licensesListView;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button moreInfobutton;
        private System.Windows.Forms.Button addLicensebutton;
        private System.Windows.Forms.TextBox licenseTextBox;
    }
}