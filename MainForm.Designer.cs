using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using NewspaperBatchCreator.src;
using System.Diagnostics;
using System.DirectoryServices;

namespace NewspaperBatchCreator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addFilesTextBox = new TextBox();
            addFilesButton = new Button();
            selectFolderButton = new Button();
            statusBar = new StatusStrip();
            statusBar_NumberOfFilesAdded = new ToolStripStatusLabel();
            statusBar_MetadataLoaded = new ToolStripStatusLabel();
            statusBar_NumberOfCompletedFiles = new ToolStripStatusLabel();
            exitButton = new Button();
            startOverButton = new Button();
            createBatchButton = new Button();
            addFilesLabel = new Label();
            addFiles_folderBrowserDialog = new FolderBrowserDialog();
            viewLogsButton = new Button();
            sourceFilesListView = new ListView();
            sourceFilesListFilenameCol = new ColumnHeader();
            sourceFilesListStatusCol = new ColumnHeader();
            settingsButton = new Button();
            importMetadataButton = new Button();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // addFilesTextBox
            // 
            addFilesTextBox.Location = new Point(12, 32);
            addFilesTextBox.Name = "addFilesTextBox";
            addFilesTextBox.ReadOnly = true;
            addFilesTextBox.Size = new Size(926, 27);
            addFilesTextBox.TabIndex = 0;
            // 
            // addFilesButton
            // 
            addFilesButton.Location = new Point(1100, 31);
            addFilesButton.Name = "addFilesButton";
            addFilesButton.Size = new Size(150, 29);
            addFilesButton.TabIndex = 1;
            addFilesButton.Text = "Add Files";
            addFilesButton.UseVisualStyleBackColor = true;
            addFilesButton.Click += loadSourceFilesButton_Click;
            // 
            // selectFolderButton
            // 
            selectFolderButton.Location = new Point(944, 31);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Size = new Size(150, 29);
            selectFolderButton.TabIndex = 2;
            selectFolderButton.Text = "... Select Folder ...";
            selectFolderButton.UseVisualStyleBackColor = true;
            selectFolderButton.Click += browseSourceFilesButton_Click;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { statusBar_NumberOfFilesAdded, statusBar_MetadataLoaded, statusBar_NumberOfCompletedFiles });
            statusBar.Location = new Point(0, 647);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(1262, 26);
            statusBar.TabIndex = 7;
            statusBar.Text = "statusBar";
            // 
            // statusBar_NumberOfFilesAdded
            // 
            statusBar_NumberOfFilesAdded.Name = "statusBar_NumberOfFilesAdded";
            statusBar_NumberOfFilesAdded.Padding = new Padding(15, 0, 0, 0);
            statusBar_NumberOfFilesAdded.Size = new Size(126, 20);
            statusBar_NumberOfFilesAdded.Text = "No Files Added";
            // 
            // statusBar_MetadataLoaded
            // 
            statusBar_MetadataLoaded.Name = "statusBar_MetadataLoaded";
            statusBar_MetadataLoaded.Padding = new Padding(15, 0, 0, 0);
            statusBar_MetadataLoaded.Size = new Size(166, 20);
            statusBar_MetadataLoaded.Text = "No Metadata Loaded";
            // 
            // statusBar_NumberOfCompletedFiles
            // 
            statusBar_NumberOfCompletedFiles.Name = "statusBar_NumberOfCompletedFiles";
            statusBar_NumberOfCompletedFiles.Padding = new Padding(15, 0, 0, 0);
            statusBar_NumberOfCompletedFiles.Size = new Size(143, 20);
            statusBar_NumberOfCompletedFiles.Text = "0 Files Completed";
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Location = new Point(1130, 608);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(120, 29);
            exitButton.TabIndex = 10;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // startOverButton
            // 
            startOverButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            startOverButton.Location = new Point(692, 608);
            startOverButton.Name = "startOverButton";
            startOverButton.Size = new Size(150, 29);
            startOverButton.TabIndex = 11;
            startOverButton.Text = "Start Over";
            startOverButton.UseVisualStyleBackColor = true;
            startOverButton.Click += startOverButton_Click;
            // 
            // createBatchButton
            // 
            createBatchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            createBatchButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createBatchButton.Location = new Point(216, 608);
            createBatchButton.Name = "createBatchButton";
            createBatchButton.Size = new Size(200, 29);
            createBatchButton.TabIndex = 12;
            createBatchButton.Text = "Create Batch";
            createBatchButton.UseVisualStyleBackColor = true;
            createBatchButton.Click += assembleBatchButton_Click;
            // 
            // addFilesLabel
            // 
            addFilesLabel.AutoSize = true;
            addFilesLabel.Location = new Point(12, 9);
            addFilesLabel.Name = "addFilesLabel";
            addFilesLabel.Size = new Size(73, 20);
            addFilesLabel.TabIndex = 13;
            addFilesLabel.Text = "Add Files:";
            // 
            // viewLogsButton
            // 
            viewLogsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            viewLogsButton.Location = new Point(974, 608);
            viewLogsButton.Name = "viewLogsButton";
            viewLogsButton.Size = new Size(150, 29);
            viewLogsButton.TabIndex = 20;
            viewLogsButton.Text = "View Logs";
            viewLogsButton.UseVisualStyleBackColor = true;
            viewLogsButton.Click += viewLogsButton_Click;
            // 
            // sourceFilesListView
            // 
            sourceFilesListView.Columns.AddRange(new ColumnHeader[] { sourceFilesListFilenameCol, sourceFilesListStatusCol });
            sourceFilesListView.Location = new Point(12, 66);
            sourceFilesListView.Name = "sourceFilesListView";
            sourceFilesListView.Size = new Size(1238, 536);
            sourceFilesListView.TabIndex = 23;
            sourceFilesListView.UseCompatibleStateImageBehavior = false;
            sourceFilesListView.View = View.Details;
            // 
            // sourceFilesListFilenameCol
            // 
            sourceFilesListFilenameCol.Text = "Filename";
            // 
            // sourceFilesListStatusCol
            // 
            sourceFilesListStatusCol.Text = "Status";
            // 
            // settingsButton
            // 
            settingsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            settingsButton.Location = new Point(848, 608);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(120, 29);
            settingsButton.TabIndex = 22;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += optionsButton_Click;
            // 
            // importMetadataButton
            // 
            importMetadataButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            importMetadataButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importMetadataButton.Location = new Point(10, 608);
            importMetadataButton.Name = "importMetadataButton";
            importMetadataButton.Size = new Size(200, 29);
            importMetadataButton.TabIndex = 24;
            importMetadataButton.Text = "Import Metadata";
            importMetadataButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(importMetadataButton);
            Controls.Add(sourceFilesListView);
            Controls.Add(settingsButton);
            Controls.Add(viewLogsButton);
            Controls.Add(addFilesLabel);
            Controls.Add(createBatchButton);
            Controls.Add(startOverButton);
            Controls.Add(exitButton);
            Controls.Add(statusBar);
            Controls.Add(selectFolderButton);
            Controls.Add(addFilesButton);
            Controls.Add(addFilesTextBox);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "MainForm";
            Text = "Newspaper Batch Creation";
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Initializations

        //Item status definitions:
        internal static readonly int LOADED = 0, COMPLETED = 1, SKIPPED = 2;
        internal static readonly Dictionary<int, string> STATUS = new Dictionary<int, string>
        {
            { LOADED, "LOADED" },
            { COMPLETED, "COMPLETED" },
            { SKIPPED, "SKIPPED"}
        };

        internal Button selectFolderButton;
        internal Button createBatchButton;
        internal ToolStripStatusLabel statusBar_MetadataLoaded;
        internal ToolStripStatusLabel statusBar_NumberOfCompletedFiles;

        LogForm logForm;
        SettingsForm settingsForm;
        ImportMetadataForm importMetadataForm;


        List<DestinationFilesStructure> destinationFileStructure;
        Dictionary<string, Batch_XML_Issue_Element> batch_XML_Issue_Elements;
        string batchXmlFileFullPath = String.Empty;

        Dictionary<string, IssueFilesInformation> issueFilesInformation;

        private void CustomInitialization()
        {
            //Custom form start location:
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2 - 50);

            //Initialize forms:
            logForm = new LogForm(this);
            importMetadataForm = new ImportMetadataForm(this);
            settingsForm = new SettingsForm(this);

            //Pass along the logForm instance:
            importMetadataForm.logForm = logForm;
            settingsForm.logForm = logForm;

            //Disable buttons upon application startup:
            selectFolderButton.Enabled = false;
            addFilesButton.Enabled = false;
            createBatchButton.Enabled = false;

            //Load LCCN selection ComboBox items:
            loadLccnComboBoxItems();
            //selectLccnComboBox.SelectedIndexChanged += lccnComboBox_SelectedIndexChanged;

            //Set ListView properties:
            sourceFilesListFilenameCol.Width = sourceFilesListView.Width - 150;
            sourceFilesListStatusCol.Width = 100;

            //Initialize other resources:
            destinationFileStructure = new List<DestinationFilesStructure>();
            batch_XML_Issue_Elements = new Dictionary<string, Batch_XML_Issue_Element>();
            issueFilesInformation = new Dictionary<string, IssueFilesInformation>();

            InitializeSettings();
        }

        private void InitializeSettings()
        {
            Properties.Settings.Default.SeletedLccn = String.Empty;
            Properties.Settings.Default.OutputFolder = Environment.CurrentDirectory;
            Properties.Settings.Default.SourceFolder = String.Empty;
            Properties.Settings.Default.Awardee = "txa";
            Properties.Settings.Default.AwardYear = String.Empty;
            Properties.Settings.Default.MetadataLoaded = false;
            Properties.Settings.Default.SourceFilesLoaded = false;

            //settingsForm.editionOrderComboBox.SelectedIndex = 0;
            //Properties.Settings.Default.EditionOrder = settingsForm.editionOrderComboBox.SelectedItem?.ToString();

            settingsForm.outputFolderTextBox.Text = Properties.Settings.Default.OutputFolder;
            settingsForm.selectOutputFolder_folderBrowserDialog.SelectedPath = Properties.Settings.Default.OutputFolder;

            Properties.Settings.Default.Save();

            //Print current default settings to logs:
            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"\"SelectedLccn\" is set to: {Properties.Settings.Default.SeletedLccn}");
            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"\"OutputFolder\" is set to: {Properties.Settings.Default.OutputFolder}");
            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"\"SourceFolder\" is set to: {Properties.Settings.Default.SourceFolder}");
            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"\"Awardee\" is set to: {Properties.Settings.Default.Awardee}");
            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"\"AwardYear\" is set to: {Properties.Settings.Default.AwardYear}");
            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"\"EditionOrder\" is set to: {Properties.Settings.Default.EditionOrder}");
        }

        #endregion

        private TextBox addFilesTextBox;
        private Button addFilesButton;
        private Label label3;
        private StatusStrip statusBar;
        private Button exitButton;
        private Button startOverButton;
        private Label addFilesLabel;
        private FolderBrowserDialog addFiles_folderBrowserDialog;
        internal Button viewLogsButton;
        private Button settingsButton;
        internal ListView sourceFilesListView;
        private ColumnHeader sourceFilesListFilenameCol;
        private ColumnHeader sourceFilesListStatusCol;
        private ToolStripStatusLabel statusBar_NumberOfFilesAdded;
        internal Button importMetadataButton;
    }
}
