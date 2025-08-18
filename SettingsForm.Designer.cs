using NewspaperBatchCreation.src;
using System.Drawing.Interop;

namespace NewspaperBatchCreation
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
            settingsTabControl = new TabControl();
            applicationAndBatchSettingsTab = new TabPage();
            issueFolderValidationRegexTextBox = new TextBox();
            issueFolderNameValidationRegexLabel = new Label();
            batchNamePrefixLabel = new Label();
            batchNamePrefixTextBox = new TextBox();
            selectLccnComboBox = new ComboBox();
            selectLccnLabel = new Label();
            batchNumberTextBox = new TextBox();
            batchNumberLabel = new Label();
            selectOutputFolderLabel = new Label();
            browseOutputFolderButton = new Button();
            outputFolderTextBox = new TextBox();
            manageNewspaperTitlesTab = new TabPage();
            manageNewspaperTitlesDataGridView = new DataGridView();
            settingsStatusStrip = new StatusStrip();
            resetToDefaultButton = new Button();
            saveButton = new Button();
            settingsTabControl.SuspendLayout();
            applicationAndBatchSettingsTab.SuspendLayout();
            manageNewspaperTitlesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)manageNewspaperTitlesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Location = new Point(1130, 619);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(120, 29);
            closeButton.TabIndex = 33;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += saveAndCloseButton_Click;
            // 
            // settingsTabControl
            // 
            settingsTabControl.Controls.Add(applicationAndBatchSettingsTab);
            settingsTabControl.Controls.Add(manageNewspaperTitlesTab);
            settingsTabControl.Location = new Point(12, 12);
            settingsTabControl.Name = "settingsTabControl";
            settingsTabControl.SelectedIndex = 0;
            settingsTabControl.Size = new Size(1238, 601);
            settingsTabControl.TabIndex = 46;
            // 
            // applicationAndBatchSettingsTab
            // 
            applicationAndBatchSettingsTab.Controls.Add(issueFolderValidationRegexTextBox);
            applicationAndBatchSettingsTab.Controls.Add(issueFolderNameValidationRegexLabel);
            applicationAndBatchSettingsTab.Controls.Add(batchNamePrefixLabel);
            applicationAndBatchSettingsTab.Controls.Add(batchNamePrefixTextBox);
            applicationAndBatchSettingsTab.Controls.Add(selectLccnComboBox);
            applicationAndBatchSettingsTab.Controls.Add(selectLccnLabel);
            applicationAndBatchSettingsTab.Controls.Add(batchNumberTextBox);
            applicationAndBatchSettingsTab.Controls.Add(batchNumberLabel);
            applicationAndBatchSettingsTab.Controls.Add(selectOutputFolderLabel);
            applicationAndBatchSettingsTab.Controls.Add(browseOutputFolderButton);
            applicationAndBatchSettingsTab.Controls.Add(outputFolderTextBox);
            applicationAndBatchSettingsTab.Location = new Point(4, 29);
            applicationAndBatchSettingsTab.Name = "applicationAndBatchSettingsTab";
            applicationAndBatchSettingsTab.Padding = new Padding(3);
            applicationAndBatchSettingsTab.Size = new Size(1230, 568);
            applicationAndBatchSettingsTab.TabIndex = 0;
            applicationAndBatchSettingsTab.Text = "Application and Batch Settings";
            applicationAndBatchSettingsTab.UseVisualStyleBackColor = true;
            // 
            // issueFolderValidationRegexTextBox
            // 
            issueFolderValidationRegexTextBox.Location = new Point(6, 156);
            issueFolderValidationRegexTextBox.Name = "issueFolderValidationRegexTextBox";
            issueFolderValidationRegexTextBox.Size = new Size(1218, 27);
            issueFolderValidationRegexTextBox.TabIndex = 52;
            // 
            // issueFolderNameValidationRegexLabel
            // 
            issueFolderNameValidationRegexLabel.AutoSize = true;
            issueFolderNameValidationRegexLabel.Location = new Point(6, 133);
            issueFolderNameValidationRegexLabel.Name = "issueFolderNameValidationRegexLabel";
            issueFolderNameValidationRegexLabel.Size = new Size(298, 20);
            issueFolderNameValidationRegexLabel.TabIndex = 51;
            issueFolderNameValidationRegexLabel.Text = "Issue Folder Name Validation Regex (Input):";
            // 
            // batchNamePrefixLabel
            // 
            batchNamePrefixLabel.AutoSize = true;
            batchNamePrefixLabel.Location = new Point(497, 68);
            batchNamePrefixLabel.Name = "batchNamePrefixLabel";
            batchNamePrefixLabel.Size = new Size(134, 20);
            batchNamePrefixLabel.TabIndex = 50;
            batchNamePrefixLabel.Text = "Batch Name Prefix:";
            // 
            // batchNamePrefixTextBox
            // 
            batchNamePrefixTextBox.Location = new Point(497, 91);
            batchNamePrefixTextBox.Name = "batchNamePrefixTextBox";
            batchNamePrefixTextBox.ReadOnly = true;
            batchNamePrefixTextBox.Size = new Size(491, 27);
            batchNamePrefixTextBox.TabIndex = 49;
            batchNamePrefixTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // selectLccnComboBox
            // 
            selectLccnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectLccnComboBox.FormattingEnabled = true;
            selectLccnComboBox.Location = new Point(6, 91);
            selectLccnComboBox.Name = "selectLccnComboBox";
            selectLccnComboBox.Size = new Size(485, 28);
            selectLccnComboBox.TabIndex = 48;
            // 
            // selectLccnLabel
            // 
            selectLccnLabel.AutoSize = true;
            selectLccnLabel.Location = new Point(6, 68);
            selectLccnLabel.Name = "selectLccnLabel";
            selectLccnLabel.Size = new Size(91, 20);
            selectLccnLabel.TabIndex = 47;
            selectLccnLabel.Text = "Select LCCN:";
            // 
            // batchNumberTextBox
            // 
            batchNumberTextBox.Location = new Point(994, 92);
            batchNumberTextBox.Name = "batchNumberTextBox";
            batchNumberTextBox.Size = new Size(230, 27);
            batchNumberTextBox.TabIndex = 46;
            // 
            // batchNumberLabel
            // 
            batchNumberLabel.AutoSize = true;
            batchNumberLabel.Location = new Point(994, 69);
            batchNumberLabel.Name = "batchNumberLabel";
            batchNumberLabel.Size = new Size(210, 20);
            batchNumberLabel.TabIndex = 45;
            batchNumberLabel.Text = "Batch Number (numbers only):";
            // 
            // selectOutputFolderLabel
            // 
            selectOutputFolderLabel.AutoSize = true;
            selectOutputFolderLabel.Location = new Point(6, 29);
            selectOutputFolderLabel.Name = "selectOutputFolderLabel";
            selectOutputFolderLabel.Size = new Size(104, 20);
            selectOutputFolderLabel.TabIndex = 38;
            selectOutputFolderLabel.Text = "Output Folder:";
            // 
            // browseOutputFolderButton
            // 
            browseOutputFolderButton.Location = new Point(994, 20);
            browseOutputFolderButton.Name = "browseOutputFolderButton";
            browseOutputFolderButton.Size = new Size(230, 29);
            browseOutputFolderButton.TabIndex = 37;
            browseOutputFolderButton.Text = "... Select Output Folder ...";
            browseOutputFolderButton.UseVisualStyleBackColor = true;
            // 
            // outputFolderTextBox
            // 
            outputFolderTextBox.Location = new Point(116, 22);
            outputFolderTextBox.Name = "outputFolderTextBox";
            outputFolderTextBox.ReadOnly = true;
            outputFolderTextBox.Size = new Size(872, 27);
            outputFolderTextBox.TabIndex = 36;
            // 
            // manageNewspaperTitlesTab
            // 
            manageNewspaperTitlesTab.Controls.Add(manageNewspaperTitlesDataGridView);
            manageNewspaperTitlesTab.Location = new Point(4, 29);
            manageNewspaperTitlesTab.Name = "manageNewspaperTitlesTab";
            manageNewspaperTitlesTab.Size = new Size(1230, 568);
            manageNewspaperTitlesTab.TabIndex = 2;
            manageNewspaperTitlesTab.Text = "Manage Newspaper Titles";
            manageNewspaperTitlesTab.UseVisualStyleBackColor = true;
            // 
            // manageNewspaperTitlesDataGridView
            // 
            manageNewspaperTitlesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            manageNewspaperTitlesDataGridView.Location = new Point(3, 3);
            manageNewspaperTitlesDataGridView.Name = "manageNewspaperTitlesDataGridView";
            manageNewspaperTitlesDataGridView.RowHeadersWidth = 51;
            manageNewspaperTitlesDataGridView.Size = new Size(1224, 562);
            manageNewspaperTitlesDataGridView.TabIndex = 0;
            // 
            // settingsStatusStrip
            // 
            settingsStatusStrip.ImageScalingSize = new Size(20, 20);
            settingsStatusStrip.Location = new Point(0, 651);
            settingsStatusStrip.Name = "settingsStatusStrip";
            settingsStatusStrip.Size = new Size(1262, 22);
            settingsStatusStrip.TabIndex = 47;
            settingsStatusStrip.Text = "statusStrip1";
            // 
            // resetToDefaultButton
            // 
            resetToDefaultButton.Location = new Point(778, 619);
            resetToDefaultButton.Name = "resetToDefaultButton";
            resetToDefaultButton.Size = new Size(220, 29);
            resetToDefaultButton.TabIndex = 53;
            resetToDefaultButton.Text = "Reset to Default";
            resetToDefaultButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(1004, 619);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 29);
            saveButton.TabIndex = 54;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            ControlBox = false;
            Controls.Add(saveButton);
            Controls.Add(resetToDefaultButton);
            Controls.Add(settingsStatusStrip);
            Controls.Add(settingsTabControl);
            Controls.Add(closeButton);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "SettingsForm";
            Text = "Settings";
            settingsTabControl.ResumeLayout(false);
            applicationAndBatchSettingsTab.ResumeLayout(false);
            applicationAndBatchSettingsTab.PerformLayout();
            manageNewspaperTitlesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)manageNewspaperTitlesDataGridView).EndInit();
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

            outputFolderTextBox.Text = Properties.Settings.Default.OutputFolder;
        }

        #endregion

        private Button closeButton;
        internal FolderBrowserDialog selectMetadataFile_folderBrowserDialog;
        private TabControl settingsTabControl;
        private TabPage applicationAndBatchSettingsTab;
        private TextBox issueFolderValidationRegexTextBox;
        private Label issueFolderNameValidationRegexLabel;
        private Label batchNamePrefixLabel;
        private TextBox batchNamePrefixTextBox;
        internal ComboBox selectLccnComboBox;
        private Label selectLccnLabel;
        private TextBox batchNumberTextBox;
        private Label batchNumberLabel;
        private Label selectOutputFolderLabel;
        private Button browseOutputFolderButton;
        public TextBox outputFolderTextBox;
        private StatusStrip settingsStatusStrip;
        private Button resetToDefaultButton;
        private TabPage manageNewspaperTitlesTab;
        private DataGridView manageNewspaperTitlesDataGridView;
        private Button saveButton;
    }
}