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
            settingsTabControl = new TabControl();
            applicationSettingsTab = new TabPage();
            issueFolderValidationRegexTextBox = new TextBox();
            issueFolderNameValidationRegexLabel = new Label();
            selectOutputFolderLabel = new Label();
            browseOutputFolderButton = new Button();
            outputFolderTextBox = new TextBox();
            batchSettingsTab = new TabPage();
            physicalLocationShortCodeTextBoxLabel = new Label();
            physicalLocationShortCodeTextBox = new TextBox();
            awardeeFullNameTextBoxLabel = new Label();
            awardeeFullNameTextBox = new TextBox();
            awardYearTextBox = new TextBox();
            awardYearTextBoxLabel = new Label();
            awardeeShortCodeTextBox = new TextBox();
            awardeeShortCodeTextBoxLabel = new Label();
            batchTypeComboBox = new ComboBox();
            batchTypeComboBoxLabel = new Label();
            batchNamePrefixLabel = new Label();
            batchNamePrefixTextBox = new TextBox();
            selectLccnComboBox = new ComboBox();
            selectLccnComboBoxLabel = new Label();
            batchNumberTextBox = new TextBox();
            batchNumberLabel = new Label();
            manageNewspaperTitlesTab = new TabPage();
            manageNewspaperTitlesDataGridView = new DataGridView();
            lccnCol = new DataGridViewTextBoxColumn();
            titleFullCol = new DataGridViewTextBoxColumn();
            titleShortCol = new DataGridViewTextBoxColumn();
            batchPrefixCol = new DataGridViewTextBoxColumn();
            settingsStatusStrip = new StatusStrip();
            resetToDefaultButton = new Button();
            saveButton = new Button();
            physicalLocationFullAddrTextBoxLabel = new Label();
            physicalLocationFullAddrTextBox = new TextBox();
            agencyResponsibleForReproductionFullAddrTextBox = new TextBox();
            agencyResponsibleForReproductionFullAddrTextBoxLabel = new Label();
            agencyResponsibleForReproductionShortCodeTextBoxLabel = new Label();
            agencyResponsibleForReproductionShortCodeTextBox = new TextBox();
            noteAboutReproductionTextBoxLabel = new Label();
            noteAboutReproductionTextBox = new TextBox();
            settingsTabControl.SuspendLayout();
            applicationSettingsTab.SuspendLayout();
            batchSettingsTab.SuspendLayout();
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
            settingsTabControl.Controls.Add(applicationSettingsTab);
            settingsTabControl.Controls.Add(batchSettingsTab);
            settingsTabControl.Controls.Add(manageNewspaperTitlesTab);
            settingsTabControl.Location = new Point(12, 12);
            settingsTabControl.Name = "settingsTabControl";
            settingsTabControl.SelectedIndex = 0;
            settingsTabControl.Size = new Size(1238, 601);
            settingsTabControl.TabIndex = 46;
            // 
            // applicationSettingsTab
            // 
            applicationSettingsTab.Controls.Add(issueFolderValidationRegexTextBox);
            applicationSettingsTab.Controls.Add(issueFolderNameValidationRegexLabel);
            applicationSettingsTab.Controls.Add(selectOutputFolderLabel);
            applicationSettingsTab.Controls.Add(browseOutputFolderButton);
            applicationSettingsTab.Controls.Add(outputFolderTextBox);
            applicationSettingsTab.Location = new Point(4, 29);
            applicationSettingsTab.Name = "applicationSettingsTab";
            applicationSettingsTab.Padding = new Padding(3);
            applicationSettingsTab.Size = new Size(1230, 568);
            applicationSettingsTab.TabIndex = 0;
            applicationSettingsTab.Text = "Application Settings";
            applicationSettingsTab.UseVisualStyleBackColor = true;
            // 
            // issueFolderValidationRegexTextBox
            // 
            issueFolderValidationRegexTextBox.Location = new Point(9, 109);
            issueFolderValidationRegexTextBox.Name = "issueFolderValidationRegexTextBox";
            issueFolderValidationRegexTextBox.Size = new Size(1215, 27);
            issueFolderValidationRegexTextBox.TabIndex = 52;
            // 
            // issueFolderNameValidationRegexLabel
            // 
            issueFolderNameValidationRegexLabel.AutoSize = true;
            issueFolderNameValidationRegexLabel.Location = new Point(6, 86);
            issueFolderNameValidationRegexLabel.Name = "issueFolderNameValidationRegexLabel";
            issueFolderNameValidationRegexLabel.Size = new Size(298, 20);
            issueFolderNameValidationRegexLabel.TabIndex = 51;
            issueFolderNameValidationRegexLabel.Text = "Issue Folder Name Validation Regex (Input):";
            // 
            // selectOutputFolderLabel
            // 
            selectOutputFolderLabel.AutoSize = true;
            selectOutputFolderLabel.Location = new Point(6, 13);
            selectOutputFolderLabel.Name = "selectOutputFolderLabel";
            selectOutputFolderLabel.Size = new Size(104, 20);
            selectOutputFolderLabel.TabIndex = 38;
            selectOutputFolderLabel.Text = "Output Folder:";
            // 
            // browseOutputFolderButton
            // 
            browseOutputFolderButton.Location = new Point(994, 36);
            browseOutputFolderButton.Name = "browseOutputFolderButton";
            browseOutputFolderButton.Size = new Size(230, 29);
            browseOutputFolderButton.TabIndex = 37;
            browseOutputFolderButton.Text = "... Select Output Folder ...";
            browseOutputFolderButton.UseVisualStyleBackColor = true;
            // 
            // outputFolderTextBox
            // 
            outputFolderTextBox.Location = new Point(9, 36);
            outputFolderTextBox.Name = "outputFolderTextBox";
            outputFolderTextBox.ReadOnly = true;
            outputFolderTextBox.Size = new Size(979, 27);
            outputFolderTextBox.TabIndex = 36;
            // 
            // batchSettingsTab
            // 
            batchSettingsTab.Controls.Add(noteAboutReproductionTextBox);
            batchSettingsTab.Controls.Add(noteAboutReproductionTextBoxLabel);
            batchSettingsTab.Controls.Add(agencyResponsibleForReproductionFullAddrTextBox);
            batchSettingsTab.Controls.Add(agencyResponsibleForReproductionFullAddrTextBoxLabel);
            batchSettingsTab.Controls.Add(agencyResponsibleForReproductionShortCodeTextBoxLabel);
            batchSettingsTab.Controls.Add(agencyResponsibleForReproductionShortCodeTextBox);
            batchSettingsTab.Controls.Add(physicalLocationFullAddrTextBox);
            batchSettingsTab.Controls.Add(physicalLocationFullAddrTextBoxLabel);
            batchSettingsTab.Controls.Add(physicalLocationShortCodeTextBoxLabel);
            batchSettingsTab.Controls.Add(physicalLocationShortCodeTextBox);
            batchSettingsTab.Controls.Add(awardeeFullNameTextBoxLabel);
            batchSettingsTab.Controls.Add(awardeeFullNameTextBox);
            batchSettingsTab.Controls.Add(awardYearTextBox);
            batchSettingsTab.Controls.Add(awardYearTextBoxLabel);
            batchSettingsTab.Controls.Add(awardeeShortCodeTextBox);
            batchSettingsTab.Controls.Add(awardeeShortCodeTextBoxLabel);
            batchSettingsTab.Controls.Add(batchTypeComboBox);
            batchSettingsTab.Controls.Add(batchTypeComboBoxLabel);
            batchSettingsTab.Controls.Add(batchNamePrefixLabel);
            batchSettingsTab.Controls.Add(batchNamePrefixTextBox);
            batchSettingsTab.Controls.Add(selectLccnComboBox);
            batchSettingsTab.Controls.Add(selectLccnComboBoxLabel);
            batchSettingsTab.Controls.Add(batchNumberTextBox);
            batchSettingsTab.Controls.Add(batchNumberLabel);
            batchSettingsTab.Location = new Point(4, 29);
            batchSettingsTab.Name = "batchSettingsTab";
            batchSettingsTab.Size = new Size(1230, 568);
            batchSettingsTab.TabIndex = 3;
            batchSettingsTab.Text = "Batch Settings";
            batchSettingsTab.UseVisualStyleBackColor = true;
            // 
            // physicalLocationShortCodeTextBoxLabel
            // 
            physicalLocationShortCodeTextBoxLabel.AutoSize = true;
            physicalLocationShortCodeTextBoxLabel.Location = new Point(824, 109);
            physicalLocationShortCodeTextBoxLabel.Name = "physicalLocationShortCodeTextBoxLabel";
            physicalLocationShortCodeTextBoxLabel.Size = new Size(209, 20);
            physicalLocationShortCodeTextBoxLabel.TabIndex = 78;
            physicalLocationShortCodeTextBoxLabel.Text = "Physical Location (short code):";
            // 
            // physicalLocationShortCodeTextBox
            // 
            physicalLocationShortCodeTextBox.Location = new Point(824, 132);
            physicalLocationShortCodeTextBox.Name = "physicalLocationShortCodeTextBox";
            physicalLocationShortCodeTextBox.Size = new Size(400, 27);
            physicalLocationShortCodeTextBox.TabIndex = 77;
            // 
            // awardeeFullNameTextBoxLabel
            // 
            awardeeFullNameTextBoxLabel.AutoSize = true;
            awardeeFullNameTextBoxLabel.Location = new Point(418, 175);
            awardeeFullNameTextBoxLabel.Name = "awardeeFullNameTextBoxLabel";
            awardeeFullNameTextBoxLabel.Size = new Size(147, 20);
            awardeeFullNameTextBoxLabel.TabIndex = 76;
            awardeeFullNameTextBoxLabel.Text = "Awardee (full name):";
            // 
            // awardeeFullNameTextBox
            // 
            awardeeFullNameTextBox.Location = new Point(418, 198);
            awardeeFullNameTextBox.Name = "awardeeFullNameTextBox";
            awardeeFullNameTextBox.Size = new Size(400, 27);
            awardeeFullNameTextBox.TabIndex = 75;
            // 
            // awardYearTextBox
            // 
            awardYearTextBox.Location = new Point(12, 198);
            awardYearTextBox.Name = "awardYearTextBox";
            awardYearTextBox.Size = new Size(400, 27);
            awardYearTextBox.TabIndex = 74;
            // 
            // awardYearTextBoxLabel
            // 
            awardYearTextBoxLabel.AutoSize = true;
            awardYearTextBoxLabel.Location = new Point(12, 175);
            awardYearTextBoxLabel.Name = "awardYearTextBoxLabel";
            awardYearTextBoxLabel.Size = new Size(87, 20);
            awardYearTextBoxLabel.TabIndex = 73;
            awardYearTextBoxLabel.Text = "Award Year:";
            // 
            // awardeeShortCodeTextBox
            // 
            awardeeShortCodeTextBox.Location = new Point(418, 132);
            awardeeShortCodeTextBox.Name = "awardeeShortCodeTextBox";
            awardeeShortCodeTextBox.Size = new Size(400, 27);
            awardeeShortCodeTextBox.TabIndex = 72;
            // 
            // awardeeShortCodeTextBoxLabel
            // 
            awardeeShortCodeTextBoxLabel.AutoSize = true;
            awardeeShortCodeTextBoxLabel.Location = new Point(418, 109);
            awardeeShortCodeTextBoxLabel.Name = "awardeeShortCodeTextBoxLabel";
            awardeeShortCodeTextBoxLabel.Size = new Size(155, 20);
            awardeeShortCodeTextBoxLabel.TabIndex = 71;
            awardeeShortCodeTextBoxLabel.Text = "Awardee (short code):";
            // 
            // batchTypeComboBox
            // 
            batchTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            batchTypeComboBox.FormattingEnabled = true;
            batchTypeComboBox.Items.AddRange(new object[] { "print", "reel" });
            batchTypeComboBox.Location = new Point(12, 132);
            batchTypeComboBox.Name = "batchTypeComboBox";
            batchTypeComboBox.Size = new Size(400, 28);
            batchTypeComboBox.TabIndex = 70;
            // 
            // batchTypeComboBoxLabel
            // 
            batchTypeComboBoxLabel.AutoSize = true;
            batchTypeComboBoxLabel.Location = new Point(12, 109);
            batchTypeComboBoxLabel.Name = "batchTypeComboBoxLabel";
            batchTypeComboBoxLabel.Size = new Size(84, 20);
            batchTypeComboBoxLabel.TabIndex = 69;
            batchTypeComboBoxLabel.Text = "Batch Type:";
            // 
            // batchNamePrefixLabel
            // 
            batchNamePrefixLabel.AutoSize = true;
            batchNamePrefixLabel.Location = new Point(418, 19);
            batchNamePrefixLabel.Name = "batchNamePrefixLabel";
            batchNamePrefixLabel.Size = new Size(134, 20);
            batchNamePrefixLabel.TabIndex = 68;
            batchNamePrefixLabel.Text = "Batch Name Prefix:";
            // 
            // batchNamePrefixTextBox
            // 
            batchNamePrefixTextBox.Location = new Point(418, 42);
            batchNamePrefixTextBox.Name = "batchNamePrefixTextBox";
            batchNamePrefixTextBox.ReadOnly = true;
            batchNamePrefixTextBox.Size = new Size(400, 27);
            batchNamePrefixTextBox.TabIndex = 67;
            batchNamePrefixTextBox.TextAlign = HorizontalAlignment.Right;
            batchNamePrefixTextBox.TextChanged += batchNamePrefixTextBox_TextChanged;
            // 
            // selectLccnComboBox
            // 
            selectLccnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectLccnComboBox.FormattingEnabled = true;
            selectLccnComboBox.Location = new Point(12, 42);
            selectLccnComboBox.Name = "selectLccnComboBox";
            selectLccnComboBox.Size = new Size(400, 28);
            selectLccnComboBox.TabIndex = 66;
            // 
            // selectLccnComboBoxLabel
            // 
            selectLccnComboBoxLabel.AutoSize = true;
            selectLccnComboBoxLabel.Location = new Point(12, 19);
            selectLccnComboBoxLabel.Name = "selectLccnComboBoxLabel";
            selectLccnComboBoxLabel.Size = new Size(91, 20);
            selectLccnComboBoxLabel.TabIndex = 65;
            selectLccnComboBoxLabel.Text = "Select LCCN:";
            // 
            // batchNumberTextBox
            // 
            batchNumberTextBox.Location = new Point(824, 42);
            batchNumberTextBox.Name = "batchNumberTextBox";
            batchNumberTextBox.Size = new Size(400, 27);
            batchNumberTextBox.TabIndex = 64;
            // 
            // batchNumberLabel
            // 
            batchNumberLabel.AutoSize = true;
            batchNumberLabel.Location = new Point(824, 19);
            batchNumberLabel.Name = "batchNumberLabel";
            batchNumberLabel.Size = new Size(210, 20);
            batchNumberLabel.TabIndex = 63;
            batchNumberLabel.Text = "Batch Number (numbers only):";
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
            manageNewspaperTitlesDataGridView.Columns.AddRange(new DataGridViewColumn[] { lccnCol, titleFullCol, titleShortCol, batchPrefixCol });
            manageNewspaperTitlesDataGridView.Location = new Point(3, 3);
            manageNewspaperTitlesDataGridView.Name = "manageNewspaperTitlesDataGridView";
            manageNewspaperTitlesDataGridView.RowHeadersWidth = 51;
            manageNewspaperTitlesDataGridView.Size = new Size(1224, 562);
            manageNewspaperTitlesDataGridView.TabIndex = 0;
            // 
            // lccnCol
            // 
            lccnCol.HeaderText = "LCCN";
            lccnCol.MinimumWidth = 6;
            lccnCol.Name = "lccnCol";
            lccnCol.Width = 125;
            // 
            // titleFullCol
            // 
            titleFullCol.HeaderText = "Title (full)";
            titleFullCol.MinimumWidth = 6;
            titleFullCol.Name = "titleFullCol";
            titleFullCol.Width = 125;
            // 
            // titleShortCol
            // 
            titleShortCol.HeaderText = "Title (short)";
            titleShortCol.MinimumWidth = 6;
            titleShortCol.Name = "titleShortCol";
            titleShortCol.Width = 125;
            // 
            // batchPrefixCol
            // 
            batchPrefixCol.HeaderText = "Batch Prefix (format: batch_awardee_short-title_ver)";
            batchPrefixCol.MinimumWidth = 6;
            batchPrefixCol.Name = "batchPrefixCol";
            batchPrefixCol.ReadOnly = true;
            batchPrefixCol.Width = 125;
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
            // physicalLocationFullAddrTextBoxLabel
            // 
            physicalLocationFullAddrTextBoxLabel.AutoSize = true;
            physicalLocationFullAddrTextBoxLabel.Location = new Point(824, 175);
            physicalLocationFullAddrTextBoxLabel.Name = "physicalLocationFullAddrTextBoxLabel";
            physicalLocationFullAddrTextBoxLabel.Size = new Size(215, 20);
            physicalLocationFullAddrTextBoxLabel.TabIndex = 80;
            physicalLocationFullAddrTextBoxLabel.Text = "Physical Location (full address):";
            // 
            // physicalLocationFullAddrTextBox
            // 
            physicalLocationFullAddrTextBox.Location = new Point(824, 198);
            physicalLocationFullAddrTextBox.Name = "physicalLocationFullAddrTextBox";
            physicalLocationFullAddrTextBox.Size = new Size(400, 27);
            physicalLocationFullAddrTextBox.TabIndex = 81;
            // 
            // agencyResponsibleForReproductionFullAddrTextBox
            // 
            agencyResponsibleForReproductionFullAddrTextBox.Location = new Point(824, 267);
            agencyResponsibleForReproductionFullAddrTextBox.Name = "agencyResponsibleForReproductionFullAddrTextBox";
            agencyResponsibleForReproductionFullAddrTextBox.Size = new Size(400, 27);
            agencyResponsibleForReproductionFullAddrTextBox.TabIndex = 85;
            // 
            // agencyResponsibleForReproductionFullAddrTextBoxLabel
            // 
            agencyResponsibleForReproductionFullAddrTextBoxLabel.AutoSize = true;
            agencyResponsibleForReproductionFullAddrTextBoxLabel.Location = new Point(824, 244);
            agencyResponsibleForReproductionFullAddrTextBoxLabel.Name = "agencyResponsibleForReproductionFullAddrTextBoxLabel";
            agencyResponsibleForReproductionFullAddrTextBoxLabel.Size = new Size(352, 20);
            agencyResponsibleForReproductionFullAddrTextBoxLabel.TabIndex = 84;
            agencyResponsibleForReproductionFullAddrTextBoxLabel.Text = "Agency Responsible for Reproduction (full address):";
            // 
            // agencyResponsibleForReproductionShortCodeTextBoxLabel
            // 
            agencyResponsibleForReproductionShortCodeTextBoxLabel.AutoSize = true;
            agencyResponsibleForReproductionShortCodeTextBoxLabel.Location = new Point(418, 244);
            agencyResponsibleForReproductionShortCodeTextBoxLabel.Name = "agencyResponsibleForReproductionShortCodeTextBoxLabel";
            agencyResponsibleForReproductionShortCodeTextBoxLabel.Size = new Size(346, 20);
            agencyResponsibleForReproductionShortCodeTextBoxLabel.TabIndex = 83;
            agencyResponsibleForReproductionShortCodeTextBoxLabel.Text = "Agency Responsible for Reproduction (short code):";
            // 
            // agencyResponsibleForReproductionShortCodeTextBox
            // 
            agencyResponsibleForReproductionShortCodeTextBox.Location = new Point(418, 267);
            agencyResponsibleForReproductionShortCodeTextBox.Name = "agencyResponsibleForReproductionShortCodeTextBox";
            agencyResponsibleForReproductionShortCodeTextBox.Size = new Size(400, 27);
            agencyResponsibleForReproductionShortCodeTextBox.TabIndex = 82;
            // 
            // noteAboutReproductionTextBoxLabel
            // 
            noteAboutReproductionTextBoxLabel.AutoSize = true;
            noteAboutReproductionTextBoxLabel.Location = new Point(12, 244);
            noteAboutReproductionTextBoxLabel.Name = "noteAboutReproductionTextBoxLabel";
            noteAboutReproductionTextBoxLabel.Size = new Size(184, 20);
            noteAboutReproductionTextBoxLabel.TabIndex = 86;
            noteAboutReproductionTextBoxLabel.Text = "Note About Reproduction:";
            // 
            // noteAboutReproductionTextBox
            // 
            noteAboutReproductionTextBox.Location = new Point(12, 267);
            noteAboutReproductionTextBox.Name = "noteAboutReproductionTextBox";
            noteAboutReproductionTextBox.Size = new Size(400, 27);
            noteAboutReproductionTextBox.TabIndex = 87;
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
            applicationSettingsTab.ResumeLayout(false);
            applicationSettingsTab.PerformLayout();
            batchSettingsTab.ResumeLayout(false);
            batchSettingsTab.PerformLayout();
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
            batchTypeComboBox.SelectedIndex = 0;
        }

        #endregion

        private Button closeButton;
        internal FolderBrowserDialog selectMetadataFile_folderBrowserDialog;
        private TabControl settingsTabControl;
        private TabPage applicationSettingsTab;
        private TextBox issueFolderValidationRegexTextBox;
        private Label issueFolderNameValidationRegexLabel;
        private Label selectOutputFolderLabel;
        private Button browseOutputFolderButton;
        public TextBox outputFolderTextBox;
        private StatusStrip settingsStatusStrip;
        private Button resetToDefaultButton;
        private TabPage manageNewspaperTitlesTab;
        private DataGridView manageNewspaperTitlesDataGridView;
        private Button saveButton;
        private DataGridViewTextBoxColumn lccnCol;
        private DataGridViewTextBoxColumn titleFullCol;
        private DataGridViewTextBoxColumn titleShortCol;
        private DataGridViewTextBoxColumn batchPrefixCol;
        private TabPage batchSettingsTab;
        private Label physicalLocationShortCodeTextBoxLabel;
        private TextBox physicalLocationShortCodeTextBox;
        private Label awardeeFullNameTextBoxLabel;
        private TextBox awardeeFullNameTextBox;
        private TextBox awardYearTextBox;
        private Label awardYearTextBoxLabel;
        private TextBox awardeeShortCodeTextBox;
        private Label awardeeShortCodeTextBoxLabel;
        internal ComboBox batchTypeComboBox;
        private Label batchTypeComboBoxLabel;
        private Label batchNamePrefixLabel;
        private TextBox batchNamePrefixTextBox;
        internal ComboBox selectLccnComboBox;
        private Label selectLccnComboBoxLabel;
        private TextBox batchNumberTextBox;
        private Label batchNumberLabel;
        private Label physicalLocationFullAddrTextBoxLabel;
        private TextBox physicalLocationFullAddrTextBox;
        private TextBox agencyResponsibleForReproductionFullAddrTextBox;
        private Label agencyResponsibleForReproductionFullAddrTextBoxLabel;
        private Label agencyResponsibleForReproductionShortCodeTextBoxLabel;
        private TextBox agencyResponsibleForReproductionShortCodeTextBox;
        private TextBox noteAboutReproductionTextBox;
        private Label noteAboutReproductionTextBoxLabel;
    }
}