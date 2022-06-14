namespace Simply_add_a_license.Commands
{
    partial class Window
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
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Recommended licenses", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("All licenses", System.Windows.Forms.HorizontalAlignment.Left);
            this.licencesListView = new System.Windows.Forms.ListView();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.licenseInfoSplitContainer = new System.Windows.Forms.SplitContainer();
            this.addLicensebutton = new System.Windows.Forms.Button();
            this.moreInfobutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.licenseTextBox = new System.Windows.Forms.TextBox();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseInfoSplitContainer)).BeginInit();
            this.licenseInfoSplitContainer.Panel1.SuspendLayout();
            this.licenseInfoSplitContainer.Panel2.SuspendLayout();
            this.licenseInfoSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // licencesListView
            // 
            this.licencesListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.licencesListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.licencesListView.FullRowSelect = true;
            listViewGroup5.Header = "Recommended licenses";
            listViewGroup5.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup5.Name = "Recommended";
            listViewGroup6.Header = "All licenses";
            listViewGroup6.Name = "All";
            this.licencesListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6});
            this.licencesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.licencesListView.HideSelection = false;
            this.licencesListView.Location = new System.Drawing.Point(0, 0);
            this.licencesListView.MultiSelect = false;
            this.licencesListView.Name = "licencesListView";
            this.licencesListView.Size = new System.Drawing.Size(200, 450);
            this.licencesListView.TabIndex = 0;
            this.licencesListView.UseCompatibleStateImageBehavior = false;
            this.licencesListView.View = System.Windows.Forms.View.Tile;
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
            // licenseInfoSplitContainer
            // 
            this.licenseInfoSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licenseInfoSplitContainer.Location = new System.Drawing.Point(200, 0);
            this.licenseInfoSplitContainer.Name = "licenseInfoSplitContainer";
            this.licenseInfoSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // licenseInfoSplitContainer.Panel1
            // 
            this.licenseInfoSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // licenseInfoSplitContainer.Panel2
            // 
            this.licenseInfoSplitContainer.Panel2.Controls.Add(this.licenseTextBox);
            this.licenseInfoSplitContainer.Size = new System.Drawing.Size(600, 418);
            this.licenseInfoSplitContainer.SplitterDistance = 114;
            this.licenseInfoSplitContainer.TabIndex = 2;
            // 
            // addLicensebutton
            // 
            this.addLicensebutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addLicensebutton.Location = new System.Drawing.Point(300, 0);
            this.addLicensebutton.Name = "addLicensebutton";
            this.addLicensebutton.Size = new System.Drawing.Size(300, 32);
            this.addLicensebutton.TabIndex = 0;
            this.addLicensebutton.Text = "Add license";
            this.addLicensebutton.UseVisualStyleBackColor = true;
            // 
            // moreInfobutton
            // 
            this.moreInfobutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moreInfobutton.Location = new System.Drawing.Point(0, 0);
            this.moreInfobutton.Name = "moreInfobutton";
            this.moreInfobutton.Size = new System.Drawing.Size(300, 32);
            this.moreInfobutton.TabIndex = 1;
            this.moreInfobutton.Text = "More info";
            this.moreInfobutton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 114);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.licenseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licenseTextBox.Location = new System.Drawing.Point(0, 0);
            this.licenseTextBox.Multiline = true;
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.ReadOnly = true;
            this.licenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.licenseTextBox.Size = new System.Drawing.Size(600, 300);
            this.licenseTextBox.TabIndex = 0;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.licenseInfoSplitContainer);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.licencesListView);
            this.Name = "Window";
            this.Text = "Simply add a license";
            this.buttonsPanel.ResumeLayout(false);
            this.licenseInfoSplitContainer.Panel1.ResumeLayout(false);
            this.licenseInfoSplitContainer.Panel2.ResumeLayout(false);
            this.licenseInfoSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseInfoSplitContainer)).EndInit();
            this.licenseInfoSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView licencesListView;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.SplitContainer licenseInfoSplitContainer;
        private System.Windows.Forms.Button moreInfobutton;
        private System.Windows.Forms.Button addLicensebutton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox licenseTextBox;
    }
}