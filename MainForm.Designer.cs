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
            statusBar = new StatusStrip();
            statusBar_NumberOfFilesAddedFrom = new ToolStripStatusLabel();
            statusBar_MetadataLoaded = new ToolStripStatusLabel();
            statusBar_NumberOfCompletedFiles = new ToolStripStatusLabel();
            createBatchButton = new Button();
            from_folderBrowserDialog = new FolderBrowserDialog();
            sourceFilesListView = new ListView();
            sourceFilesListFilenameCol = new ColumnHeader();
            sourceFilesListStatusCol = new ColumnHeader();
            menuStrip = new MenuStrip();
            filesToolStripMenuItem = new ToolStripMenuItem();
            browseMenuItem = new ToolStripMenuItem();
            metadataMenuItem = new ToolStripMenuItem();
            exportTemplate_MetadataSubMenuItem = new ToolStripMenuItem();
            importEditMetadata_MetadataSubMenuItem = new ToolStripMenuItem();
            settingsMenuItem = new ToolStripMenuItem();
            viewLogsMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            documentationToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            metadataFile_folderBrowserDialog = new FolderBrowserDialog();
            exportMetadataTemplate_saveFileDialog = new SaveFileDialog();
            statusBar.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { statusBar_NumberOfFilesAddedFrom, statusBar_MetadataLoaded, statusBar_NumberOfCompletedFiles });
            statusBar.Location = new Point(0, 489);
            statusBar.Name = "statusBar";
            statusBar.Padding = new Padding(1, 0, 12, 0);
            statusBar.Size = new Size(1106, 22);
            statusBar.TabIndex = 7;
            statusBar.Text = "statusBar";
            // 
            // statusBar_NumberOfFilesAddedFrom
            // 
            statusBar_NumberOfFilesAddedFrom.Name = "statusBar_NumberOfFilesAddedFrom";
            statusBar_NumberOfFilesAddedFrom.Padding = new Padding(15, 0, 0, 0);
            statusBar_NumberOfFilesAddedFrom.Size = new Size(102, 17);
            statusBar_NumberOfFilesAddedFrom.Text = "No Files Added";
            // 
            // statusBar_MetadataLoaded
            // 
            statusBar_MetadataLoaded.Name = "statusBar_MetadataLoaded";
            statusBar_MetadataLoaded.Padding = new Padding(15, 0, 0, 0);
            statusBar_MetadataLoaded.Size = new Size(133, 17);
            statusBar_MetadataLoaded.Text = "No Metadata Loaded";
            // 
            // statusBar_NumberOfCompletedFiles
            // 
            statusBar_NumberOfCompletedFiles.Name = "statusBar_NumberOfCompletedFiles";
            statusBar_NumberOfCompletedFiles.Padding = new Padding(15, 0, 0, 0);
            statusBar_NumberOfCompletedFiles.Size = new Size(116, 17);
            statusBar_NumberOfCompletedFiles.Text = "0 Files Completed";
            // 
            // createBatchButton
            // 
            createBatchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            createBatchButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createBatchButton.Location = new Point(944, 4);
            createBatchButton.Margin = new Padding(3, 2, 3, 2);
            createBatchButton.Name = "createBatchButton";
            createBatchButton.Size = new Size(150, 22);
            createBatchButton.TabIndex = 12;
            createBatchButton.Text = "Create Batch";
            createBatchButton.UseVisualStyleBackColor = true;
            createBatchButton.Click += createBatchButton_Click;
            // 
            // sourceFilesListView
            // 
            sourceFilesListView.Columns.AddRange(new ColumnHeader[] { sourceFilesListFilenameCol, sourceFilesListStatusCol });
            sourceFilesListView.Location = new Point(10, 30);
            sourceFilesListView.Margin = new Padding(3, 2, 3, 2);
            sourceFilesListView.Name = "sourceFilesListView";
            sourceFilesListView.Size = new Size(1084, 448);
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
            // menuStrip
            // 
            menuStrip.AutoSize = false;
            menuStrip.BackColor = SystemColors.Control;
            menuStrip.Dock = DockStyle.None;
            menuStrip.Items.AddRange(new ToolStripItem[] { filesToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(941, 24);
            menuStrip.TabIndex = 25;
            menuStrip.Text = "menuStrip";
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { browseMenuItem, metadataMenuItem, settingsMenuItem, viewLogsMenuItem, resetToolStripMenuItem, exitMenuItem });
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(42, 20);
            filesToolStripMenuItem.Text = "Files";
            // 
            // browseMenuItem
            // 
            browseMenuItem.Name = "browseMenuItem";
            browseMenuItem.Size = new Size(180, 22);
            browseMenuItem.Text = "Browse ...";
            browseMenuItem.Click += browseMenuItem_Click;
            // 
            // metadataMenuItem
            // 
            metadataMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportTemplate_MetadataSubMenuItem, importEditMetadata_MetadataSubMenuItem });
            metadataMenuItem.Name = "metadataMenuItem";
            metadataMenuItem.Size = new Size(180, 22);
            metadataMenuItem.Text = "Metadata";
            // 
            // exportTemplate_MetadataSubMenuItem
            // 
            exportTemplate_MetadataSubMenuItem.Name = "exportTemplate_MetadataSubMenuItem";
            exportTemplate_MetadataSubMenuItem.Size = new Size(190, 22);
            exportTemplate_MetadataSubMenuItem.Text = "Export Template (.csv)";
            exportTemplate_MetadataSubMenuItem.Click += exportTemplate_MetadataSubMenuItem_Click;
            // 
            // importEditMetadata_MetadataSubMenuItem
            // 
            importEditMetadata_MetadataSubMenuItem.Name = "importEditMetadata_MetadataSubMenuItem";
            importEditMetadata_MetadataSubMenuItem.Size = new Size(190, 22);
            importEditMetadata_MetadataSubMenuItem.Text = "Import/Edit Metadata";
            importEditMetadata_MetadataSubMenuItem.Click += importEditMetadata_MetadataSubMenuItem_Click;
            // 
            // settingsMenuItem
            // 
            settingsMenuItem.Name = "settingsMenuItem";
            settingsMenuItem.Size = new Size(180, 22);
            settingsMenuItem.Text = "Settings";
            settingsMenuItem.Click += settingsMenuItem_Click;
            // 
            // viewLogsMenuItem
            // 
            viewLogsMenuItem.Name = "viewLogsMenuItem";
            viewLogsMenuItem.Size = new Size(180, 22);
            viewLogsMenuItem.Text = "View Logs";
            viewLogsMenuItem.Click += viewLogsMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(180, 22);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(180, 22);
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { documentationToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            documentationToolStripMenuItem.Size = new Size(157, 22);
            documentationToolStripMenuItem.Text = "Documentation";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(157, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 511);
            Controls.Add(sourceFilesListView);
            Controls.Add(createBatchButton);
            Controls.Add(statusBar);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1122, 550);
            MinimumSize = new Size(1122, 550);
            Name = "MainForm";
            Text = "Newspaper Batch Creator";
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Initializations
        
        //Override default OnShown behavior:
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.ActiveControl = null;
        }
        protected override void WndProc(ref Message m)
        {
            int WM_PARENTNOTIFY = 0x0210;
            if (!this.Focused && m.Msg == WM_PARENTNOTIFY)
            {
                this.Activate();
            }
            base.WndProc(ref m);
        }

        //Item status definitions:
        internal static readonly (string ADDED, string PROCESSED, string SKIPPED) STATUS = ("ADDED", "PROCESSED", "SKIPPED");
        internal Button createBatchButton;
        internal ToolStripStatusLabel statusBar_MetadataLoaded;
        internal ToolStripStatusLabel statusBar_NumberOfCompletedFiles;

        private LogForm logForm;
        private SettingsForm settingsForm;
        private ImportEditMetadataForm importEditMetadataForm;

        internal Utilities utilities;

        internal Dictionary<string, Issue> issueMetadata;

        //List<DestinationFilesStructure> destinationFileStructure;
        //Dictionary<string, Batch_XML_Issue_Element> batch_XML_Issue_Elements;
        //string batchXmlFileFullPath = String.Empty;

        string selectedPath = String.Empty;
        Boolean sourceFilesLoaded = false;
        Boolean metadataLoaded = false;

        //Dictionary<string, IssueFilesInformation> issueFilesInformation;

        private void CustomInitialization()
        {
            //Initialize forms:

            //Custom form start location:
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2 - 50);

            //Initialize LogForm:
            logForm = new LogForm(this);

            //Initialize ImportEditMetadataForm:
            importEditMetadataForm = new ImportEditMetadataForm(this, this.logForm);

            //Initialize SettingsForm:
            settingsForm = new SettingsForm(this);


            //Initialize components:

            //Initialize utilities:
            utilities = new Utilities(this, logForm);

            //Initialize issueMetadata:
            issueMetadata = new Dictionary<string, Issue>();

            //Disable buttons upon application startup:
            //browseButton.Enabled = true;
            //addFilesButton.Enabled = false;
            createBatchButton.Enabled = false;

            //Load LCCN selection ComboBox items:
            //loadLccnComboBoxItems();
            //selectLccnComboBox.SelectedIndexChanged += lccnComboBox_SelectedIndexChanged;

            //Set ListView properties:
            sourceFilesListFilenameCol.Width = sourceFilesListView.Width - 150;
            sourceFilesListStatusCol.Width = 100;

            //Initialize other resources:
            //destinationFileStructure = new List<DestinationFilesStructure>();
            //batch_XML_Issue_Elements = new Dictionary<string, Batch_XML_Issue_Element>();
            //issueFilesInformation = new Dictionary<string, IssueFilesInformation>();

            InitializeSettings();
        }

        private void InitializeSettings()
        {
            //Properties.Settings.Default.SeletedLccn = String.Empty;
            //Properties.Settings.Default.SourceFolder = Environment.CurrentDirectory;
            Properties.Settings.Default.OutputFolder = String.Empty;
            //Properties.Settings.Default.Awardee = "txa";
            //Properties.Settings.Default.AwardYear = String.Empty;
            //Properties.Settings.Default.LogFolder = false;
            //Properties.Settings.Default.SourceFilesLoaded = false;

            //settingsForm.editionOrderComboBox.SelectedIndex = 0;
            //Properties.Settings.Default.EditionOrder = settingsForm.editionOrderComboBox.SelectedItem?.ToString();

            //settingsForm.outputFolderTextBox.Text = Properties.Settings.Default.OutputFolder;
            //settingsForm.selectOutputFolder_folderBrowserDialog.SelectedPath = Properties.Settings.Default.SourceFolder;

            Properties.Settings.Default.Save();

            //Print current default settings to logs:
            //logForm.SendToLog(LogForm.LogType.INFO, $"\"SelectedLccn\" is set to: {Properties.Settings.Default.SeletedLccn}");
            //logForm.SendToLog(LogForm.LogType.INFO, $"\"OutputFolder\" is set to: {Properties.Settings.Default.SourceFolder}");
            logForm.SendToLog(LogForm.LogType.INFO, $"\"SourceFolder\" is set to: {Properties.Settings.Default.OutputFolder}");
            //logForm.SendToLog(LogForm.LogType.INFO, $"\"Awardee\" is set to: {Properties.Settings.Default.Awardee}");
            //logForm.SendToLog(LogForm.LogType.INFO, $"\"AwardYear\" is set to: {Properties.Settings.Default.AwardYear}");
            //logForm.SendToLog(LogForm.LogType.INFO, $"\"EditionOrder\" is set to: {Properties.Settings.Default.EditionOrder}");
        }

        #endregion
        private StatusStrip statusBar;
        private FolderBrowserDialog from_folderBrowserDialog;
        internal ListView sourceFilesListView;
        private ColumnHeader sourceFilesListFilenameCol;
        private ColumnHeader sourceFilesListStatusCol;
        private ToolStripStatusLabel statusBar_NumberOfFilesAddedFrom;
        private MenuStrip menuStrip;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem browseMenuItem;
        private ToolStripMenuItem settingsMenuItem;
        private ToolStripMenuItem viewLogsMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem documentationToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private FolderBrowserDialog metadataFile_folderBrowserDialog;
        private ToolStripMenuItem metadataMenuItem;
        private ToolStripMenuItem exportTemplate_MetadataSubMenuItem;
        private ToolStripMenuItem importEditMetadata_MetadataSubMenuItem;
        private SaveFileDialog exportMetadataTemplate_saveFileDialog;
    }
}
