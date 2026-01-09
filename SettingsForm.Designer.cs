using NewspaperBatchCreator.src;
using System.Drawing.Interop;

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
            selectOutputFolder_folderBrowserDialog = new FolderBrowserDialog();
            closeButton = new Button();
            selectMetadataFile_folderBrowserDialog = new FolderBrowserDialog();
            settingsStatusStrip = new StatusStrip();
            saveButton = new Button();
            settingsTabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            resetToDefaultButton = new Button();
            settingsTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Location = new Point(985, 465);
            closeButton.Margin = new Padding(3, 2, 3, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(105, 22);
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
            saveButton.Location = new Point(874, 465);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(105, 22);
            saveButton.TabIndex = 54;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // settingsTabControl
            // 
            settingsTabControl.Controls.Add(tabPage1);
            settingsTabControl.Controls.Add(tabPage2);
            settingsTabControl.Controls.Add(tabPage3);
            settingsTabControl.Location = new Point(12, 12);
            settingsTabControl.Name = "settingsTabControl";
            settingsTabControl.SelectedIndex = 0;
            settingsTabControl.Size = new Size(1082, 448);
            settingsTabControl.TabIndex = 55;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1074, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Settings";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1074, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Organizations";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1074, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Titles";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // resetToDefaultButton
            // 
            resetToDefaultButton.Location = new Point(16, 465);
            resetToDefaultButton.Margin = new Padding(3, 2, 3, 2);
            resetToDefaultButton.Name = "resetToDefaultButton";
            resetToDefaultButton.Size = new Size(130, 22);
            resetToDefaultButton.TabIndex = 56;
            resetToDefaultButton.Text = "Reset to Default";
            resetToDefaultButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 511);
            ControlBox = false;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Initializations

        private MainForm mainForm;
        public LogForm logForm;
        public FolderBrowserDialog selectOutputFolder_folderBrowserDialog;

        private void CustomInitialization()
        {
            //Custom form start location:
            this.StartPosition = FormStartPosition.Manual;

            selectLccnComboBox.SelectedIndex = 0;
            selectLccnComboBox.Visible = false;
            settingsTabControl.SelectedIndexChanged += settingsTabControl_SelectedIndexChanged;

            //outputFolderTextBox.Text = Properties.Settings.Default.OutputFolder;
            //batchTypeComboBox.SelectedIndex = 0;
        }

        #endregion Custom Initializations

        private Button closeButton;
        internal FolderBrowserDialog selectMetadataFile_folderBrowserDialog;
        private StatusStrip settingsStatusStrip;
        private Button saveButton;
        private TabControl settingsTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button resetToDefaultButton;
    }
}