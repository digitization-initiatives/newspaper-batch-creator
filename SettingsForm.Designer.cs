using NewspaperBatchCreator.src;
using System.Drawing.Interop;
using System.Windows.Forms;

namespace NewspaperBatchCreator
{
    partial class SettingsForm
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
            closeButton = new Button();
            selectMetadataFile_folderBrowserDialog = new FolderBrowserDialog();
            settingsStatusStrip = new StatusStrip();
            saveButton = new Button();
            settingsTabControl = new TabControl();
            settingsTabPage = new TabPage();
            settingsPropertyGrid = new PropertyGrid();
            organizationsTabPage = new TabPage();
            organizationsSplitContainer = new SplitContainer();
            organizationsListBox = new ListBox();
            organizationsPropertyGrid = new PropertyGrid();
            titlesTabPage = new TabPage();
            titlesSplitContainer = new SplitContainer();
            resetToDefaultButton = new Button();
            refreshButton = new Button();
            titlesListBox = new ListBox();
            titlesPropertyGrid = new PropertyGrid();
            settingsTabControl.SuspendLayout();
            settingsTabPage.SuspendLayout();
            organizationsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)organizationsSplitContainer).BeginInit();
            organizationsSplitContainer.Panel1.SuspendLayout();
            organizationsSplitContainer.Panel2.SuspendLayout();
            organizationsSplitContainer.SuspendLayout();
            titlesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)titlesSplitContainer).BeginInit();
            titlesSplitContainer.Panel1.SuspendLayout();
            titlesSplitContainer.Panel2.SuspendLayout();
            titlesSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Location = new Point(989, 463);
            closeButton.Margin = new Padding(3, 2, 3, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(105, 23);
            closeButton.TabIndex = 33;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += saveAndCloseButton_Click;
            // 
            // settingsStatusStrip
            // 
            settingsStatusStrip.ImageScalingSize = new Size(20, 20);
            settingsStatusStrip.Location = new Point(0, 489);
            settingsStatusStrip.Name = "settingsStatusStrip";
            settingsStatusStrip.Padding = new Padding(1, 0, 12, 0);
            settingsStatusStrip.Size = new Size(1106, 22);
            settingsStatusStrip.TabIndex = 47;
            settingsStatusStrip.Text = "statusStrip1";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(878, 463);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(105, 23);
            saveButton.TabIndex = 54;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // settingsTabControl
            // 
            settingsTabControl.Controls.Add(settingsTabPage);
            settingsTabControl.Controls.Add(organizationsTabPage);
            settingsTabControl.Controls.Add(titlesTabPage);
            settingsTabControl.Location = new Point(12, 12);
            settingsTabControl.Name = "settingsTabControl";
            settingsTabControl.SelectedIndex = 0;
            settingsTabControl.Size = new Size(1082, 448);
            settingsTabControl.TabIndex = 55;
            // 
            // settingsTabPage
            // 
            settingsTabPage.Controls.Add(settingsPropertyGrid);
            settingsTabPage.Location = new Point(4, 24);
            settingsTabPage.Name = "settingsTabPage";
            settingsTabPage.Padding = new Padding(3);
            settingsTabPage.Size = new Size(1074, 420);
            settingsTabPage.TabIndex = 0;
            settingsTabPage.Text = "Settings";
            settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsPropertyGrid
            // 
            settingsPropertyGrid.BackColor = SystemColors.Control;
            settingsPropertyGrid.CategoryForeColor = SystemColors.ButtonFace;
            settingsPropertyGrid.CommandsBorderColor = SystemColors.ControlLight;
            settingsPropertyGrid.DisabledItemForeColor = SystemColors.Control;
            settingsPropertyGrid.LineColor = SystemColors.ControlLight;
            settingsPropertyGrid.Location = new Point(6, 6);
            settingsPropertyGrid.Name = "settingsPropertyGrid";
            settingsPropertyGrid.Size = new Size(1062, 408);
            settingsPropertyGrid.TabIndex = 0;
            settingsPropertyGrid.ViewBackColor = SystemColors.ControlLightLight;
            // 
            // organizationsTabPage
            // 
            organizationsTabPage.Controls.Add(organizationsSplitContainer);
            organizationsTabPage.Location = new Point(4, 24);
            organizationsTabPage.Name = "organizationsTabPage";
            organizationsTabPage.Padding = new Padding(3);
            organizationsTabPage.Size = new Size(1074, 420);
            organizationsTabPage.TabIndex = 1;
            organizationsTabPage.Text = "Organizations";
            organizationsTabPage.UseVisualStyleBackColor = true;
            // 
            // organizationsSplitContainer
            // 
            organizationsSplitContainer.Dock = DockStyle.Fill;
            organizationsSplitContainer.Location = new Point(3, 3);
            organizationsSplitContainer.Name = "organizationsSplitContainer";
            // 
            // organizationsSplitContainer.Panel1
            // 
            organizationsSplitContainer.Panel1.Controls.Add(organizationsListBox);
            organizationsSplitContainer.Panel1.Cursor = Cursors.SizeAll;
            // 
            // organizationsSplitContainer.Panel2
            // 
            organizationsSplitContainer.Panel2.Controls.Add(organizationsPropertyGrid);
            organizationsSplitContainer.Size = new Size(1068, 414);
            organizationsSplitContainer.SplitterDistance = 200;
            organizationsSplitContainer.TabIndex = 0;
            // 
            // organizationsListBox
            // 
            organizationsListBox.FormattingEnabled = true;
            organizationsListBox.ItemHeight = 15;
            organizationsListBox.Location = new Point(3, 3);
            organizationsListBox.Name = "organizationsListBox";
            organizationsListBox.Size = new Size(194, 409);
            organizationsListBox.TabIndex = 0;
            // 
            // organizationsPropertyGrid
            // 
            organizationsPropertyGrid.Location = new Point(3, 3);
            organizationsPropertyGrid.Name = "organizationsPropertyGrid";
            organizationsPropertyGrid.Size = new Size(858, 408);
            organizationsPropertyGrid.TabIndex = 1;
            // 
            // titlesTabPage
            // 
            titlesTabPage.Controls.Add(titlesSplitContainer);
            titlesTabPage.Location = new Point(4, 24);
            titlesTabPage.Name = "titlesTabPage";
            titlesTabPage.Padding = new Padding(3);
            titlesTabPage.Size = new Size(1074, 420);
            titlesTabPage.TabIndex = 2;
            titlesTabPage.Text = "Titles";
            titlesTabPage.UseVisualStyleBackColor = true;
            // 
            // titlesSplitContainer
            // 
            titlesSplitContainer.Dock = DockStyle.Fill;
            titlesSplitContainer.Location = new Point(3, 3);
            titlesSplitContainer.Name = "titlesSplitContainer";
            // 
            // titlesSplitContainer.Panel1
            // 
            titlesSplitContainer.Panel1.Controls.Add(titlesListBox);
            // 
            // titlesSplitContainer.Panel2
            // 
            titlesSplitContainer.Panel2.Controls.Add(titlesPropertyGrid);
            titlesSplitContainer.Size = new Size(1068, 414);
            titlesSplitContainer.SplitterDistance = 200;
            titlesSplitContainer.TabIndex = 0;
            // 
            // resetToDefaultButton
            // 
            resetToDefaultButton.Location = new Point(12, 463);
            resetToDefaultButton.Margin = new Padding(3, 2, 3, 2);
            resetToDefaultButton.Name = "resetToDefaultButton";
            resetToDefaultButton.Size = new Size(130, 23);
            resetToDefaultButton.TabIndex = 56;
            resetToDefaultButton.Text = "Reset to Default";
            resetToDefaultButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(148, 463);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(130, 23);
            refreshButton.TabIndex = 1;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // titlesListBox
            // 
            titlesListBox.FormattingEnabled = true;
            titlesListBox.ItemHeight = 15;
            titlesListBox.Location = new Point(3, 3);
            titlesListBox.Name = "titlesListBox";
            titlesListBox.Size = new Size(194, 409);
            titlesListBox.TabIndex = 0;
            // 
            // titlesPropertyGrid
            // 
            titlesPropertyGrid.Location = new Point(0, 0);
            titlesPropertyGrid.Name = "titlesPropertyGrid";
            titlesPropertyGrid.Size = new Size(864, 411);
            titlesPropertyGrid.TabIndex = 0;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 511);
            ControlBox = false;
            Controls.Add(refreshButton);
            Controls.Add(resetToDefaultButton);
            Controls.Add(saveButton);
            Controls.Add(settingsTabControl);
            Controls.Add(closeButton);
            Controls.Add(settingsStatusStrip);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1122, 550);
            MinimumSize = new Size(1122, 550);
            Name = "SettingsForm";
            Text = "Settings";
            settingsTabControl.ResumeLayout(false);
            settingsTabPage.ResumeLayout(false);
            organizationsTabPage.ResumeLayout(false);
            organizationsSplitContainer.Panel1.ResumeLayout(false);
            organizationsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)organizationsSplitContainer).EndInit();
            organizationsSplitContainer.ResumeLayout(false);
            titlesTabPage.ResumeLayout(false);
            titlesSplitContainer.Panel1.ResumeLayout(false);
            titlesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)titlesSplitContainer).EndInit();
            titlesSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Initializations
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.ActiveControl = null;
        }

        private MainForm mainForm;
        private LogForm logForm;

        private Utilities utilities;

        private void CustomInitialization()
        {
            //Custom form start location:
            this.StartPosition = FormStartPosition.Manual;

            //Initialize or load components:
            utilities = new Utilities(mainForm, logForm);

            settingsPropertyGrid.SelectedObject = Properties.Settings.Default;
            organizationsPropertyGrid.SelectedObject = Properties.Settings.Default;
            titlesPropertyGrid.SelectedObject= Properties.Settings.Default;

            PropertyGridSplitter.SetSplitterByRatio(settingsPropertyGrid, 0.30);
            PropertyGridSplitter.SetSplitterByRatio(organizationsPropertyGrid, 0.30);
            PropertyGridSplitter.SetSplitterByRatio(titlesPropertyGrid, 0.30);

            utilities.LoadJSONFilesIntoListBox(organizationsListBox, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "organizations"));
            organizationsListBox.SelectedIndexChanged += organizationsListBox_SelectedIndexChanged;
        }

        #endregion Custom Initializations

        private Button closeButton;
        internal FolderBrowserDialog selectMetadataFile_folderBrowserDialog;
        private StatusStrip settingsStatusStrip;
        private Button saveButton;
        private TabControl settingsTabControl;
        private TabPage settingsTabPage;
        private TabPage organizationsTabPage;
        private TabPage titlesTabPage;
        private Button resetToDefaultButton;
        private PropertyGrid settingsPropertyGrid;
        private SplitContainer organizationsSplitContainer;
        private ListBox organizationsListBox;
        private PropertyGrid organizationsPropertyGrid;
        private SplitContainer titlesSplitContainer;
        private Button refreshButton;
        private ListBox titlesListBox;
        private PropertyGrid titlesPropertyGrid;
    }
}