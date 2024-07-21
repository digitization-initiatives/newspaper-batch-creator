using NewspaperBatchAssemblyTool.src;

namespace NewspaperBatchAssemblyTool
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
            sourceFilesPathTextBox = new TextBox();
            loadSourceFilesButton = new Button();
            browseSourceFilesButton = new Button();
            selectLccnLabel = new Label();
            batchNumberLabel = new Label();
            lccnComboBox = new ComboBox();
            statusBar = new StatusStrip();
            statusBarNumberOfSourceFilesLabel = new ToolStripStatusLabel();
            statusBarMetadataFileLoadedLabel = new ToolStripStatusLabel();
            statusBarNumberOfAssembledFilesLabel = new ToolStripStatusLabel();
            batchNamePrefixTextBox = new TextBox();
            batchNumberTextBox = new TextBox();
            exitButton = new Button();
            startOverButton = new Button();
            assembleBatchButton = new Button();
            browseSourceFilesLabel = new Label();
            browseSourceFiles_folderBrowserDialog = new FolderBrowserDialog();
            viewLogsButton = new Button();
            sourceFilesListView = new ListView();
            sourceFilesListFilenameCol = new ColumnHeader();
            sourceFilesListStatusCol = new ColumnHeader();
            optionsButton = new Button();
            setBatchNumberButton = new Button();
            importMetadataButton = new Button();
            batchNamePrefixLabel = new Label();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // sourceFilesPathTextBox
            // 
            sourceFilesPathTextBox.Location = new Point(12, 32);
            sourceFilesPathTextBox.Name = "sourceFilesPathTextBox";
            sourceFilesPathTextBox.ReadOnly = true;
            sourceFilesPathTextBox.Size = new Size(926, 27);
            sourceFilesPathTextBox.TabIndex = 0;
            // 
            // loadSourceFilesButton
            // 
            loadSourceFilesButton.Location = new Point(1100, 31);
            loadSourceFilesButton.Name = "loadSourceFilesButton";
            loadSourceFilesButton.Size = new Size(150, 29);
            loadSourceFilesButton.TabIndex = 1;
            loadSourceFilesButton.Text = "Load Source Files";
            loadSourceFilesButton.UseVisualStyleBackColor = true;
            loadSourceFilesButton.Click += loadSourceFilesButton_Click;
            // 
            // browseSourceFilesButton
            // 
            browseSourceFilesButton.Location = new Point(944, 31);
            browseSourceFilesButton.Name = "browseSourceFilesButton";
            browseSourceFilesButton.Size = new Size(150, 29);
            browseSourceFilesButton.TabIndex = 2;
            browseSourceFilesButton.Text = "... Browse ...";
            browseSourceFilesButton.UseVisualStyleBackColor = true;
            browseSourceFilesButton.Click += browseSourceFilesButton_Click;
            // 
            // selectLccnLabel
            // 
            selectLccnLabel.AutoSize = true;
            selectLccnLabel.Location = new Point(12, 77);
            selectLccnLabel.Name = "selectLccnLabel";
            selectLccnLabel.Size = new Size(91, 20);
            selectLccnLabel.TabIndex = 3;
            selectLccnLabel.Text = "Select LCCN:";
            // 
            // batchNumberLabel
            // 
            batchNumberLabel.AutoSize = true;
            batchNumberLabel.Location = new Point(944, 77);
            batchNumberLabel.Name = "batchNumberLabel";
            batchNumberLabel.Size = new Size(210, 20);
            batchNumberLabel.TabIndex = 4;
            batchNumberLabel.Text = "Batch Number (numbers only):";
            // 
            // lccnComboBox
            // 
            lccnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            lccnComboBox.FormattingEnabled = true;
            lccnComboBox.Location = new Point(12, 100);
            lccnComboBox.Name = "lccnComboBox";
            lccnComboBox.Size = new Size(480, 28);
            lccnComboBox.TabIndex = 6;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { statusBarNumberOfSourceFilesLabel, statusBarMetadataFileLoadedLabel, statusBarNumberOfAssembledFilesLabel });
            statusBar.Location = new Point(0, 647);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(1262, 26);
            statusBar.TabIndex = 7;
            statusBar.Text = "statusBar";
            // 
            // statusBarNumberOfSourceFilesLabel
            // 
            statusBarNumberOfSourceFilesLabel.Name = "statusBarNumberOfSourceFilesLabel";
            statusBarNumberOfSourceFilesLabel.Padding = new Padding(15, 0, 0, 0);
            statusBarNumberOfSourceFilesLabel.Size = new Size(180, 20);
            statusBarNumberOfSourceFilesLabel.Text = "No Source Files Loaded";
            // 
            // statusBarMetadataFileLoadedLabel
            // 
            statusBarMetadataFileLoadedLabel.Name = "statusBarMetadataFileLoadedLabel";
            statusBarMetadataFileLoadedLabel.Padding = new Padding(15, 0, 0, 0);
            statusBarMetadataFileLoadedLabel.Size = new Size(171, 20);
            statusBarMetadataFileLoadedLabel.Text = "Metadata Not Loaded";
            // 
            // statusBarNumberOfAssembledFilesLabel
            // 
            statusBarNumberOfAssembledFilesLabel.Name = "statusBarNumberOfAssembledFilesLabel";
            statusBarNumberOfAssembledFilesLabel.Padding = new Padding(15, 0, 0, 0);
            statusBarNumberOfAssembledFilesLabel.Size = new Size(142, 20);
            statusBarNumberOfAssembledFilesLabel.Text = "0 Files Assembled";
            // 
            // batchNamePrefixTextBox
            // 
            batchNamePrefixTextBox.Location = new Point(498, 101);
            batchNamePrefixTextBox.Name = "batchNamePrefixTextBox";
            batchNamePrefixTextBox.ReadOnly = true;
            batchNamePrefixTextBox.Size = new Size(440, 27);
            batchNamePrefixTextBox.TabIndex = 8;
            batchNamePrefixTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // batchNumberTextBox
            // 
            batchNumberTextBox.Location = new Point(944, 101);
            batchNumberTextBox.Name = "batchNumberTextBox";
            batchNumberTextBox.Size = new Size(306, 27);
            batchNumberTextBox.TabIndex = 9;
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
            // assembleBatchButton
            // 
            assembleBatchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            assembleBatchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            assembleBatchButton.Location = new Point(218, 608);
            assembleBatchButton.Name = "assembleBatchButton";
            assembleBatchButton.Size = new Size(200, 29);
            assembleBatchButton.TabIndex = 12;
            assembleBatchButton.Text = "Assemble Batch";
            assembleBatchButton.UseVisualStyleBackColor = true;
            assembleBatchButton.Click += assembleBatchButton_Click;
            // 
            // browseSourceFilesLabel
            // 
            browseSourceFilesLabel.AutoSize = true;
            browseSourceFilesLabel.Location = new Point(12, 9);
            browseSourceFilesLabel.Name = "browseSourceFilesLabel";
            browseSourceFilesLabel.Size = new Size(90, 20);
            browseSourceFilesLabel.TabIndex = 13;
            browseSourceFilesLabel.Text = "Source Files:";
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
            sourceFilesListView.Location = new Point(12, 153);
            sourceFilesListView.Name = "sourceFilesListView";
            sourceFilesListView.Size = new Size(1238, 439);
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
            // optionsButton
            // 
            optionsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            optionsButton.Location = new Point(848, 608);
            optionsButton.Name = "optionsButton";
            optionsButton.Size = new Size(120, 29);
            optionsButton.TabIndex = 22;
            optionsButton.Text = "Options";
            optionsButton.UseVisualStyleBackColor = true;
            optionsButton.Click += optionsButton_Click;
            // 
            // setBatchNumberButton
            // 
            setBatchNumberButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            setBatchNumberButton.Location = new Point(800, 93);
            setBatchNumberButton.Name = "setBatchNumberButton";
            setBatchNumberButton.Size = new Size(0, 29);
            setBatchNumberButton.TabIndex = 23;
            setBatchNumberButton.Text = "Set";
            setBatchNumberButton.UseVisualStyleBackColor = true;
            setBatchNumberButton.Click += setBatchNumberButton_Click;
            // 
            // importMetadataButton
            // 
            importMetadataButton.Location = new Point(12, 608);
            importMetadataButton.Name = "importMetadataButton";
            importMetadataButton.Size = new Size(200, 29);
            importMetadataButton.TabIndex = 24;
            importMetadataButton.Text = "Import Metadata";
            importMetadataButton.UseVisualStyleBackColor = true;
            importMetadataButton.Click += importMetadataButton_Click;
            // 
            // batchNamePrefixLabel
            // 
            batchNamePrefixLabel.AutoSize = true;
            batchNamePrefixLabel.Location = new Point(498, 77);
            batchNamePrefixLabel.Name = "batchNamePrefixLabel";
            batchNamePrefixLabel.Size = new Size(134, 20);
            batchNamePrefixLabel.TabIndex = 25;
            batchNamePrefixLabel.Text = "Batch Name Prefix:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(batchNamePrefixLabel);
            Controls.Add(importMetadataButton);
            Controls.Add(sourceFilesListView);
            Controls.Add(setBatchNumberButton);
            Controls.Add(optionsButton);
            Controls.Add(viewLogsButton);
            Controls.Add(browseSourceFilesLabel);
            Controls.Add(assembleBatchButton);
            Controls.Add(startOverButton);
            Controls.Add(exitButton);
            Controls.Add(batchNumberTextBox);
            Controls.Add(batchNamePrefixTextBox);
            Controls.Add(statusBar);
            Controls.Add(lccnComboBox);
            Controls.Add(batchNumberLabel);
            Controls.Add(selectLccnLabel);
            Controls.Add(browseSourceFilesButton);
            Controls.Add(loadSourceFilesButton);
            Controls.Add(sourceFilesPathTextBox);
            MinimumSize = new Size(1280, 720);
            Name = "MainForm";
            Text = "Newspaper Batch Assembly Tool";
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Initializations

        public string STATUS_LOADED = "Loaded";
        public string STATUS_ASSEMBLED = "Assembled";
        public string STATUS_SKIPPED = "Skipped";

        LogForm logForm;
        ImportMetadataForm importMetadataForm;

        private void CustomInitialization()
        {
            logForm = new LogForm(this);
            importMetadataForm = new ImportMetadataForm(this);
            importMetadataForm.logForm = logForm;

            loadSourceFilesButton.Enabled = false;

            loadLccnComboBoxItems();
            lccnComboBox.SelectedIndexChanged += lccnComboBox_SelectedIndexChanged;

            sourceFilesListFilenameCol.Width = sourceFilesListView.Width - 150;
            sourceFilesListStatusCol.Width = 100;
        }

        #endregion


        private TextBox sourceFilesPathTextBox;
        private Button loadSourceFilesButton;
        private Button browseSourceFilesButton;
        private Label selectLccnLabel;
        private Label batchNumberLabel;
        private Label label3;
        private ComboBox lccnComboBox;
        private StatusStrip statusBar;
        private TextBox batchNumberTextBox;
        private TextBox batchNamePrefixTextBox;
        private Button exitButton;
        private Button startOverButton;
        private Button assembleBatchButton;
        private Label browseSourceFilesLabel;
        private FolderBrowserDialog browseSourceFiles_folderBrowserDialog;
        private Button viewLogsButton;
        private Button optionsButton;
        private ListView sourceFilesListView;
        private ColumnHeader sourceFilesListFilenameCol;
        private ColumnHeader sourceFilesListStatusCol;
        private ToolStripStatusLabel statusBarNumberOfSourceFilesLabel;
        private ToolStripStatusLabel statusBarNumberOfAssembledFilesLabel;
        private Button setBatchNumberButton;
        private Button importMetadataButton;
        private ToolStripStatusLabel statusBarMetadataFileLoadedLabel;
        private Label batchNamePrefixLabel;
    }
}
