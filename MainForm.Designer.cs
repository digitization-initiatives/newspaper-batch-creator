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
            statusBarNumberOfAssembledFilesLabel = new ToolStripStatusLabel();
            batchNumber_BatchNameTextBox = new TextBox();
            batchNumberTextBox = new TextBox();
            exitButton = new Button();
            startOverButton = new Button();
            assembleBatchButton = new Button();
            browseSourceFilesLabel = new Label();
            browseMetadataFileButton = new Button();
            metadataFilePathTextBox = new TextBox();
            metadataFileLabel = new Label();
            loadMetadataFileButton = new Button();
            browseSourceFiles_folderBrowserDialog = new FolderBrowserDialog();
            viewLogsButton = new Button();
            tabControl = new TabControl();
            sourceFilesTab = new TabPage();
            sourceFilesListView = new ListView();
            sourceFilesListFilenameCol = new ColumnHeader();
            sourceFilesListStatusCol = new ColumnHeader();
            metadataTab = new TabPage();
            metadataListView = new ListView();
            optionsButton = new Button();
            browseMetadataFile_openFileDialog = new OpenFileDialog();
            setBatchNumberButton = new Button();
            statusBar.SuspendLayout();
            tabControl.SuspendLayout();
            sourceFilesTab.SuspendLayout();
            metadataTab.SuspendLayout();
            SuspendLayout();
            // 
            // sourceFilesPathTextBox
            // 
            sourceFilesPathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sourceFilesPathTextBox.Location = new Point(12, 32);
            sourceFilesPathTextBox.Name = "sourceFilesPathTextBox";
            sourceFilesPathTextBox.ReadOnly = true;
            sourceFilesPathTextBox.Size = new Size(1196, 27);
            sourceFilesPathTextBox.TabIndex = 0;
            // 
            // loadSourceFilesButton
            // 
            loadSourceFilesButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loadSourceFilesButton.Location = new Point(1370, 31);
            loadSourceFilesButton.Name = "loadSourceFilesButton";
            loadSourceFilesButton.Size = new Size(200, 29);
            loadSourceFilesButton.TabIndex = 1;
            loadSourceFilesButton.Text = "Load Source Files";
            loadSourceFilesButton.UseVisualStyleBackColor = true;
            loadSourceFilesButton.Click += loadSourceFilesButton_Click;
            // 
            // browseSourceFilesButton
            // 
            browseSourceFilesButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            browseSourceFilesButton.Location = new Point(1214, 31);
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
            selectLccnLabel.Location = new Point(12, 143);
            selectLccnLabel.Name = "selectLccnLabel";
            selectLccnLabel.Size = new Size(91, 20);
            selectLccnLabel.TabIndex = 3;
            selectLccnLabel.Text = "Select LCCN:";
            // 
            // batchNumberLabel
            // 
            batchNumberLabel.AutoSize = true;
            batchNumberLabel.Location = new Point(584, 143);
            batchNumberLabel.Name = "batchNumberLabel";
            batchNumberLabel.Size = new Size(210, 20);
            batchNumberLabel.TabIndex = 4;
            batchNumberLabel.Text = "Batch Number (numbers only):";
            // 
            // lccnComboBox
            // 
            lccnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            lccnComboBox.FormattingEnabled = true;
            lccnComboBox.Location = new Point(12, 166);
            lccnComboBox.Name = "lccnComboBox";
            lccnComboBox.Size = new Size(400, 28);
            lccnComboBox.TabIndex = 6;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { statusBarNumberOfSourceFilesLabel, statusBarNumberOfAssembledFilesLabel });
            statusBar.Location = new Point(0, 827);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(1582, 26);
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
            // statusBarNumberOfAssembledFilesLabel
            // 
            statusBarNumberOfAssembledFilesLabel.Name = "statusBarNumberOfAssembledFilesLabel";
            statusBarNumberOfAssembledFilesLabel.Padding = new Padding(15, 0, 0, 0);
            statusBarNumberOfAssembledFilesLabel.Size = new Size(142, 20);
            statusBarNumberOfAssembledFilesLabel.Text = "0 Files Assembled";
            // 
            // batchNumber_BatchNameTextBox
            // 
            batchNumber_BatchNameTextBox.Location = new Point(418, 166);
            batchNumber_BatchNameTextBox.Name = "batchNumber_BatchNameTextBox";
            batchNumber_BatchNameTextBox.ReadOnly = true;
            batchNumber_BatchNameTextBox.Size = new Size(250, 27);
            batchNumber_BatchNameTextBox.TabIndex = 8;
            batchNumber_BatchNameTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // batchNumberTextBox
            // 
            batchNumberTextBox.Location = new Point(674, 166);
            batchNumberTextBox.Name = "batchNumberTextBox";
            batchNumberTextBox.Size = new Size(120, 27);
            batchNumberTextBox.TabIndex = 9;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Location = new Point(1450, 788);
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
            startOverButton.Location = new Point(1012, 788);
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
            assembleBatchButton.Location = new Point(806, 788);
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
            // browseMetadataFileButton
            // 
            browseMetadataFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            browseMetadataFileButton.Location = new Point(1214, 95);
            browseMetadataFileButton.Name = "browseMetadataFileButton";
            browseMetadataFileButton.Size = new Size(150, 29);
            browseMetadataFileButton.TabIndex = 15;
            browseMetadataFileButton.Text = "... Browse ...";
            browseMetadataFileButton.UseVisualStyleBackColor = true;
            browseMetadataFileButton.Click += browseMetadataFileButton_Click;
            // 
            // metadataFilePathTextBox
            // 
            metadataFilePathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            metadataFilePathTextBox.Location = new Point(12, 96);
            metadataFilePathTextBox.Name = "metadataFilePathTextBox";
            metadataFilePathTextBox.ReadOnly = true;
            metadataFilePathTextBox.Size = new Size(1196, 27);
            metadataFilePathTextBox.TabIndex = 14;
            // 
            // metadataFileLabel
            // 
            metadataFileLabel.AutoSize = true;
            metadataFileLabel.Location = new Point(12, 73);
            metadataFileLabel.Name = "metadataFileLabel";
            metadataFileLabel.Size = new Size(103, 20);
            metadataFileLabel.TabIndex = 16;
            metadataFileLabel.Text = "Metadata File:";
            // 
            // loadMetadataFileButton
            // 
            loadMetadataFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loadMetadataFileButton.Location = new Point(1370, 96);
            loadMetadataFileButton.Name = "loadMetadataFileButton";
            loadMetadataFileButton.Size = new Size(200, 29);
            loadMetadataFileButton.TabIndex = 17;
            loadMetadataFileButton.Text = "Load Metadata File";
            loadMetadataFileButton.UseVisualStyleBackColor = true;
            loadMetadataFileButton.Click += loadMetadataFileButton_Click;
            // 
            // viewLogsButton
            // 
            viewLogsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            viewLogsButton.Location = new Point(1294, 788);
            viewLogsButton.Name = "viewLogsButton";
            viewLogsButton.Size = new Size(150, 29);
            viewLogsButton.TabIndex = 20;
            viewLogsButton.Text = "View Logs";
            viewLogsButton.UseVisualStyleBackColor = true;
            viewLogsButton.Click += viewLogsButton_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(sourceFilesTab);
            tabControl.Controls.Add(metadataTab);
            tabControl.Location = new Point(12, 219);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1558, 563);
            tabControl.TabIndex = 21;
            // 
            // sourceFilesTab
            // 
            sourceFilesTab.Controls.Add(sourceFilesListView);
            sourceFilesTab.Location = new Point(4, 29);
            sourceFilesTab.Name = "sourceFilesTab";
            sourceFilesTab.Padding = new Padding(3);
            sourceFilesTab.Size = new Size(1550, 530);
            sourceFilesTab.TabIndex = 0;
            sourceFilesTab.Text = "View Source Files";
            sourceFilesTab.UseVisualStyleBackColor = true;
            // 
            // sourceFilesListView
            // 
            sourceFilesListView.Columns.AddRange(new ColumnHeader[] { sourceFilesListFilenameCol, sourceFilesListStatusCol });
            sourceFilesListView.Location = new Point(6, 6);
            sourceFilesListView.Name = "sourceFilesListView";
            sourceFilesListView.Size = new Size(1538, 518);
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
            // metadataTab
            // 
            metadataTab.Controls.Add(metadataListView);
            metadataTab.Location = new Point(4, 29);
            metadataTab.Name = "metadataTab";
            metadataTab.Padding = new Padding(3);
            metadataTab.Size = new Size(1550, 530);
            metadataTab.TabIndex = 1;
            metadataTab.Text = "View Metadata";
            metadataTab.UseVisualStyleBackColor = true;
            // 
            // metadataListView
            // 
            metadataListView.Location = new Point(6, 6);
            metadataListView.Name = "metadataListView";
            metadataListView.Size = new Size(1538, 518);
            metadataListView.TabIndex = 0;
            metadataListView.UseCompatibleStateImageBehavior = false;
            metadataListView.View = View.List;
            // 
            // optionsButton
            // 
            optionsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            optionsButton.Location = new Point(1168, 788);
            optionsButton.Name = "optionsButton";
            optionsButton.Size = new Size(120, 29);
            optionsButton.TabIndex = 22;
            optionsButton.Text = "Options";
            optionsButton.UseVisualStyleBackColor = true;
            optionsButton.Click += optionsButton_Click;
            // 
            // browseMetadataFile_openFileDialog
            // 
            browseMetadataFile_openFileDialog.FileName = "openFileDialog1";
            // 
            // setBatchNumberButton
            // 
            setBatchNumberButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            setBatchNumberButton.Location = new Point(800, 165);
            setBatchNumberButton.Name = "setBatchNumberButton";
            setBatchNumberButton.Size = new Size(80, 29);
            setBatchNumberButton.TabIndex = 23;
            setBatchNumberButton.Text = "Set";
            setBatchNumberButton.UseVisualStyleBackColor = true;
            setBatchNumberButton.Click += setBatchNumberButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(setBatchNumberButton);
            Controls.Add(optionsButton);
            Controls.Add(tabControl);
            Controls.Add(viewLogsButton);
            Controls.Add(loadMetadataFileButton);
            Controls.Add(metadataFileLabel);
            Controls.Add(browseMetadataFileButton);
            Controls.Add(metadataFilePathTextBox);
            Controls.Add(browseSourceFilesLabel);
            Controls.Add(assembleBatchButton);
            Controls.Add(startOverButton);
            Controls.Add(exitButton);
            Controls.Add(batchNumberTextBox);
            Controls.Add(batchNumber_BatchNameTextBox);
            Controls.Add(statusBar);
            Controls.Add(lccnComboBox);
            Controls.Add(batchNumberLabel);
            Controls.Add(selectLccnLabel);
            Controls.Add(browseSourceFilesButton);
            Controls.Add(loadSourceFilesButton);
            Controls.Add(sourceFilesPathTextBox);
            MinimumSize = new Size(1600, 900);
            Name = "MainForm";
            Text = "Newspaper Batch Assembly Tool";
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            tabControl.ResumeLayout(false);
            sourceFilesTab.ResumeLayout(false);
            metadataTab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Initializations

        public string STATUS_LOADED = "Loaded";
        public string STATUS_ASSEMBLED = "Assembled";
        public string STATUS_SKIPPED = "Skipped";

        LogForm logForm;


        private void CustomInitialization()
        {
            logForm = new LogForm(this);

            loadSourceFilesButton.Enabled = false;
            loadMetadataFileButton.Enabled = false;

            browseMetadataFile_openFileDialog.Filter = "Excel Files|*.xls;*.xlsx|All files (*.*)|*.*";

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
        private TextBox batchNumber_BatchNameTextBox;
        private Button exitButton;
        private Button startOverButton;
        private Button assembleBatchButton;
        private Label browseSourceFilesLabel;
        private Button browseMetadataFileButton;
        private TextBox metadataFilePathTextBox;
        private Label metadataFileLabel;
        private Button loadMetadataFileButton;
        private FolderBrowserDialog browseSourceFiles_folderBrowserDialog;
        private Button viewLogsButton;
        private TabControl tabControl;
        private TabPage sourceFilesTab;
        private TabPage metadataTab;
        private Button optionsButton;
        private ListView sourceFilesListView;
        private ColumnHeader sourceFilesListFilenameCol;
        private ListView metadataListView;
        private ColumnHeader sourceFilesListStatusCol;
        private ToolStripStatusLabel statusBarNumberOfSourceFilesLabel;
        private ToolStripStatusLabel statusBarNumberOfAssembledFilesLabel;
        private OpenFileDialog browseMetadataFile_openFileDialog;
        private Button setBatchNumberButton;
    }
}
