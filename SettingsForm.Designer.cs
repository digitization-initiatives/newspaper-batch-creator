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
            selectOutputFolderLabel = new Label();
            browseOutputFolderButton = new Button();
            outputFolderTextBox = new TextBox();
            selectOutputFolder_folderBrowserDialog = new FolderBrowserDialog();
            saveAndCloseButton = new Button();
            resetToDefaultButton = new Button();
            issueFolderValidationRegexLabel = new Label();
            addMetadataLabel = new Label();
            selectedMetadataFilePathTextBox = new TextBox();
            selectMetadataFileButton = new Button();
            addMetadata_folderBrowserDialog = new FolderBrowserDialog();
            batchNumberLabel = new Label();
            batchNumberTextBox = new TextBox();
            batchNamePrefixLabel = new Label();
            batchNamePrefixTextBox = new TextBox();
            selectLccnComboBox = new ComboBox();
            selectLccnLabel = new Label();
            issueFolderValidationRegexTextBox = new TextBox();
            SuspendLayout();
            // 
            // selectOutputFolderLabel
            // 
            selectOutputFolderLabel.AutoSize = true;
            selectOutputFolderLabel.Location = new Point(12, 9);
            selectOutputFolderLabel.Name = "selectOutputFolderLabel";
            selectOutputFolderLabel.Size = new Size(104, 20);
            selectOutputFolderLabel.TabIndex = 32;
            selectOutputFolderLabel.Text = "Output Folder:";
            // 
            // browseOutputFolderButton
            // 
            browseOutputFolderButton.Location = new Point(944, 32);
            browseOutputFolderButton.Name = "browseOutputFolderButton";
            browseOutputFolderButton.Size = new Size(306, 29);
            browseOutputFolderButton.TabIndex = 31;
            browseOutputFolderButton.Text = "... Select Output Folder ...";
            browseOutputFolderButton.UseVisualStyleBackColor = true;
            browseOutputFolderButton.Click += browseOutputFolderButton_Click;
            // 
            // outputFolderTextBox
            // 
            outputFolderTextBox.Location = new Point(12, 32);
            outputFolderTextBox.Name = "outputFolderTextBox";
            outputFolderTextBox.ReadOnly = true;
            outputFolderTextBox.Size = new Size(926, 27);
            outputFolderTextBox.TabIndex = 30;
            // 
            // saveAndCloseButton
            // 
            saveAndCloseButton.Location = new Point(1030, 632);
            saveAndCloseButton.Name = "saveAndCloseButton";
            saveAndCloseButton.Size = new Size(220, 29);
            saveAndCloseButton.TabIndex = 33;
            saveAndCloseButton.Text = "Save and Close";
            saveAndCloseButton.UseVisualStyleBackColor = true;
            saveAndCloseButton.Click += saveAndCloseButton_Click;
            // 
            // resetToDefaultButton
            // 
            resetToDefaultButton.Location = new Point(804, 632);
            resetToDefaultButton.Name = "resetToDefaultButton";
            resetToDefaultButton.Size = new Size(220, 29);
            resetToDefaultButton.TabIndex = 34;
            resetToDefaultButton.Text = "Reset to Default";
            resetToDefaultButton.UseVisualStyleBackColor = true;
            resetToDefaultButton.Click += resetToDefaultButton_Click;
            // 
            // issueFolderValidationRegexLabel
            // 
            issueFolderValidationRegexLabel.AutoSize = true;
            issueFolderValidationRegexLabel.Location = new Point(12, 235);
            issueFolderValidationRegexLabel.Name = "issueFolderValidationRegexLabel";
            issueFolderValidationRegexLabel.Size = new Size(254, 20);
            issueFolderValidationRegexLabel.TabIndex = 35;
            issueFolderValidationRegexLabel.Text = "Issue Folder Validation Regex (Input):";
            // 
            // addMetadataLabel
            // 
            addMetadataLabel.AutoSize = true;
            addMetadataLabel.Location = new Point(12, 79);
            addMetadataLabel.Name = "addMetadataLabel";
            addMetadataLabel.Size = new Size(108, 20);
            addMetadataLabel.TabIndex = 36;
            addMetadataLabel.Text = "Add Metadata:";
            // 
            // selectedMetadataFilePathTextBox
            // 
            selectedMetadataFilePathTextBox.Location = new Point(12, 102);
            selectedMetadataFilePathTextBox.Name = "selectedMetadataFilePathTextBox";
            selectedMetadataFilePathTextBox.ReadOnly = true;
            selectedMetadataFilePathTextBox.Size = new Size(926, 27);
            selectedMetadataFilePathTextBox.TabIndex = 37;
            // 
            // selectMetadataFileButton
            // 
            selectMetadataFileButton.Location = new Point(944, 101);
            selectMetadataFileButton.Name = "selectMetadataFileButton";
            selectMetadataFileButton.Size = new Size(306, 29);
            selectMetadataFileButton.TabIndex = 38;
            selectMetadataFileButton.Text = "... Select Metadata File (CSV) ...";
            selectMetadataFileButton.UseVisualStyleBackColor = true;
            // 
            // batchNumberLabel
            // 
            batchNumberLabel.AutoSize = true;
            batchNumberLabel.Location = new Point(944, 154);
            batchNumberLabel.Name = "batchNumberLabel";
            batchNumberLabel.Size = new Size(210, 20);
            batchNumberLabel.TabIndex = 39;
            batchNumberLabel.Text = "Batch Number (numbers only):";
            // 
            // batchNumberTextBox
            // 
            batchNumberTextBox.Location = new Point(944, 178);
            batchNumberTextBox.Name = "batchNumberTextBox";
            batchNumberTextBox.Size = new Size(306, 27);
            batchNumberTextBox.TabIndex = 40;
            // 
            // batchNamePrefixLabel
            // 
            batchNamePrefixLabel.AutoSize = true;
            batchNamePrefixLabel.Location = new Point(498, 154);
            batchNamePrefixLabel.Name = "batchNamePrefixLabel";
            batchNamePrefixLabel.Size = new Size(134, 20);
            batchNamePrefixLabel.TabIndex = 44;
            batchNamePrefixLabel.Text = "Batch Name Prefix:";
            // 
            // batchNamePrefixTextBox
            // 
            batchNamePrefixTextBox.Location = new Point(498, 178);
            batchNamePrefixTextBox.Name = "batchNamePrefixTextBox";
            batchNamePrefixTextBox.ReadOnly = true;
            batchNamePrefixTextBox.Size = new Size(440, 27);
            batchNamePrefixTextBox.TabIndex = 43;
            batchNamePrefixTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // selectLccnComboBox
            // 
            selectLccnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectLccnComboBox.FormattingEnabled = true;
            selectLccnComboBox.Location = new Point(12, 177);
            selectLccnComboBox.Name = "selectLccnComboBox";
            selectLccnComboBox.Size = new Size(480, 28);
            selectLccnComboBox.TabIndex = 42;
            // 
            // selectLccnLabel
            // 
            selectLccnLabel.AutoSize = true;
            selectLccnLabel.Location = new Point(12, 154);
            selectLccnLabel.Name = "selectLccnLabel";
            selectLccnLabel.Size = new Size(91, 20);
            selectLccnLabel.TabIndex = 41;
            selectLccnLabel.Text = "Select LCCN:";
            // 
            // issueFolderValidationRegexTextBox
            // 
            issueFolderValidationRegexTextBox.Location = new Point(272, 235);
            issueFolderValidationRegexTextBox.Name = "issueFolderValidationRegexTextBox";
            issueFolderValidationRegexTextBox.Size = new Size(978, 27);
            issueFolderValidationRegexTextBox.TabIndex = 45;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(issueFolderValidationRegexTextBox);
            Controls.Add(batchNamePrefixLabel);
            Controls.Add(batchNamePrefixTextBox);
            Controls.Add(selectLccnComboBox);
            Controls.Add(selectLccnLabel);
            Controls.Add(batchNumberTextBox);
            Controls.Add(batchNumberLabel);
            Controls.Add(selectMetadataFileButton);
            Controls.Add(selectedMetadataFilePathTextBox);
            Controls.Add(addMetadataLabel);
            Controls.Add(issueFolderValidationRegexLabel);
            Controls.Add(resetToDefaultButton);
            Controls.Add(saveAndCloseButton);
            Controls.Add(selectOutputFolderLabel);
            Controls.Add(browseOutputFolderButton);
            Controls.Add(outputFolderTextBox);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "SettingsForm";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Initializations

        private MainForm mainForm;
        public LogForm logForm;
        public TextBox outputFolderTextBox;
        public FolderBrowserDialog selectOutputFolder_folderBrowserDialog;

        private void CustomInitialization()
        {
            //Custom form start location:
            this.StartPosition = FormStartPosition.Manual;

            outputFolderTextBox.Text = Properties.Settings.Default.OutputFolder;
        }


        #endregion


        private Label selectOutputFolderLabel;
        private Button browseOutputFolderButton;

        private Button saveAndCloseButton;
        private Button resetToDefaultButton;
        private Label issueFolderValidationRegexLabel;
        private Label addMetadataLabel;
        internal TextBox selectedMetadataFilePathTextBox;
        private Button selectMetadataFileButton;
        internal FolderBrowserDialog addMetadata_folderBrowserDialog;
        private Label batchNumberLabel;
        private TextBox batchNumberTextBox;
        private Label batchNamePrefixLabel;
        private TextBox batchNamePrefixTextBox;
        internal ComboBox selectLccnComboBox;
        private Label selectLccnLabel;
        private TextBox issueFolderValidationRegexTextBox;
    }
}