using NewspaperBatchCreation.src;
using System.Collections.Generic;

namespace NewspaperBatchCreation
{
    partial class ImportMetadataForm
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
            resetButton = new Button();
            selectMetadataFile_openFileDialog = new OpenFileDialog();
            closeButton = new Button();
            selectMetadataFileButton = new Button();
            selectedMetadataFilePathTextBox = new TextBox();
            selectMetadataFileLabel = new Label();
            importMetadataStatusStrip = new StatusStrip();
            importMetadataStatus = new ToolStripStatusLabel();
            statusLabelDivider = new ToolStripStatusLabel();
            numberOfMetadataImportedStatusLabel = new ToolStripStatusLabel();
            numberOfMetadataImported = new ToolStripStatusLabel();
            listView1 = new ListView();
            viewSampleMetadataButton = new Button();
            importMetadataStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            resetButton.Location = new Point(1004, 615);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(120, 29);
            resetButton.TabIndex = 1;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += startOverButton_Click;
            // 
            // selectMetadataFile_openFileDialog
            // 
            selectMetadataFile_openFileDialog.FileName = "openFileDialog1";
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            closeButton.Location = new Point(1130, 615);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(120, 29);
            closeButton.TabIndex = 9;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // selectMetadataFileButton
            // 
            selectMetadataFileButton.Location = new Point(1000, 32);
            selectMetadataFileButton.Name = "selectMetadataFileButton";
            selectMetadataFileButton.Size = new Size(250, 29);
            selectMetadataFileButton.TabIndex = 44;
            selectMetadataFileButton.Text = "... Select Metadata File (CSV) ...";
            selectMetadataFileButton.UseVisualStyleBackColor = true;
            // 
            // selectedMetadataFilePathTextBox
            // 
            selectedMetadataFilePathTextBox.Location = new Point(12, 32);
            selectedMetadataFilePathTextBox.Name = "selectedMetadataFilePathTextBox";
            selectedMetadataFilePathTextBox.ReadOnly = true;
            selectedMetadataFilePathTextBox.Size = new Size(982, 27);
            selectedMetadataFilePathTextBox.TabIndex = 43;
            // 
            // selectMetadataFileLabel
            // 
            selectMetadataFileLabel.AutoSize = true;
            selectMetadataFileLabel.Location = new Point(12, 9);
            selectMetadataFileLabel.Name = "selectMetadataFileLabel";
            selectMetadataFileLabel.Size = new Size(147, 20);
            selectMetadataFileLabel.TabIndex = 42;
            selectMetadataFileLabel.Text = "Select Metadata File:";
            // 
            // importMetadataStatusStrip
            // 
            importMetadataStatusStrip.ImageScalingSize = new Size(20, 20);
            importMetadataStatusStrip.Items.AddRange(new ToolStripItem[] { importMetadataStatus, statusLabelDivider, numberOfMetadataImportedStatusLabel, numberOfMetadataImported });
            importMetadataStatusStrip.Location = new Point(0, 647);
            importMetadataStatusStrip.Name = "importMetadataStatusStrip";
            importMetadataStatusStrip.Size = new Size(1262, 26);
            importMetadataStatusStrip.TabIndex = 45;
            importMetadataStatusStrip.Text = "statusStrip1";
            // 
            // importMetadataStatus
            // 
            importMetadataStatus.Name = "importMetadataStatus";
            importMetadataStatus.Size = new Size(184, 20);
            importMetadataStatus.Text = "No metadata file selected.";
            // 
            // statusLabelDivider
            // 
            statusLabelDivider.Name = "statusLabelDivider";
            statusLabelDivider.Size = new Size(21, 20);
            statusLabelDivider.Text = " | ";
            // 
            // numberOfMetadataImportedStatusLabel
            // 
            numberOfMetadataImportedStatusLabel.Name = "numberOfMetadataImportedStatusLabel";
            numberOfMetadataImportedStatusLabel.Size = new Size(218, 20);
            numberOfMetadataImportedStatusLabel.Text = "Number of metadata imported:";
            // 
            // numberOfMetadataImported
            // 
            numberOfMetadataImported.Name = "numberOfMetadataImported";
            numberOfMetadataImported.Size = new Size(15, 20);
            numberOfMetadataImported.Text = "-";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 67);
            listView1.Name = "listView1";
            listView1.Size = new Size(1238, 542);
            listView1.TabIndex = 46;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // viewSampleMetadataButton
            // 
            viewSampleMetadataButton.Location = new Point(758, 615);
            viewSampleMetadataButton.Name = "viewSampleMetadataButton";
            viewSampleMetadataButton.Size = new Size(240, 29);
            viewSampleMetadataButton.TabIndex = 47;
            viewSampleMetadataButton.Text = "View Sample Metadata";
            viewSampleMetadataButton.UseVisualStyleBackColor = true;
            // 
            // ImportMetadataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            ControlBox = false;
            Controls.Add(viewSampleMetadataButton);
            Controls.Add(listView1);
            Controls.Add(importMetadataStatusStrip);
            Controls.Add(selectMetadataFileButton);
            Controls.Add(selectedMetadataFilePathTextBox);
            Controls.Add(selectMetadataFileLabel);
            Controls.Add(closeButton);
            Controls.Add(resetButton);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "ImportMetadataForm";
            Text = "Import Metadata";
            importMetadataStatusStrip.ResumeLayout(false);
            importMetadataStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Initialization

        private MainForm mainForm;
        public LogForm logForm;
        public OpenFileDialog selectMetadataFile_openFileDialog;

        public Dictionary<string, string> mappedColumnsDict;
        public Dictionary<string, IssueMetadata> issueMetadata;

        private void CustomInitialization()
        {
            //Custom form start location:
            this.StartPosition = FormStartPosition.Manual;

            //Initialize openFileDialog:
            selectMetadataFileTextBox.Text = String.Empty;
            selectMetadataFile_openFileDialog.Filter = "Excel Files|*.xls;*.xlsx"; //Only allow Excel files to be selected.
            selectMetadataFile_openFileDialog.FileName = String.Empty;

            //Adjust DataGridView column width:
            columnMappingDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnMappingDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnMappingDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnMappingDataGridView.Columns[3].Width = 250;

            //Initialize other resources:
            mappedColumnsDict = new Dictionary<string, string>();
            issueMetadata = new Dictionary<string, IssueMetadata>();
        }

        #endregion Custom Initialization
        private Button resetButton;
        private Button closeButton;
        private Button selectMetadataFileButton;
        internal TextBox selectedMetadataFilePathTextBox;
        private Label selectMetadataFileLabel;
        private StatusStrip importMetadataStatusStrip;
        private ToolStripStatusLabel numberOfMetadataImportedStatusLabel;
        private ListView listView1;
        private ToolStripStatusLabel numberOfMetadataImported;
        private ToolStripStatusLabel importMetadataStatus;
        private ToolStripStatusLabel statusLabelDivider;
        private Button viewSampleMetadataButton;
    }
}