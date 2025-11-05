using NewspaperBatchCreator.src;
using System.Collections.Generic;

namespace NewspaperBatchCreator
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
            selectedMetadataFilePathTextBox = new TextBox();
            selectMetadataFileLabel = new Label();
            importMetadataStatusStrip = new StatusStrip();
            importMetadataStatus = new ToolStripStatusLabel();
            statusLabelDivider = new ToolStripStatusLabel();
            numberOfMetadataImportedStatusLabel = new ToolStripStatusLabel();
            numberOfMetadataImported = new ToolStripStatusLabel();
            viewMetadataTemplateButton = new Button();
            selectMetadataFileButton = new Button();
            importMetadataDataGridView = new DataGridView();
            importMetadataDataGridView_itemCol = new DataGridViewTextBoxColumn();
            importMetadataDataGridView_dateCol = new DataGridViewTextBoxColumn();
            importMetadataDataGridView_volumeCol = new DataGridViewTextBoxColumn();
            importMetadataDataGridView_issueCol = new DataGridViewTextBoxColumn();
            importMetadataDataGridView_editionCol = new DataGridViewTextBoxColumn();
            importMetadataDataGridView_pagesCol = new DataGridViewTextBoxColumn();
            importMetadataStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)importMetadataDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            resetButton.Location = new Point(878, 461);
            resetButton.Margin = new Padding(3, 2, 3, 2);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(105, 22);
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
            closeButton.Location = new Point(989, 461);
            closeButton.Margin = new Padding(3, 2, 3, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(105, 22);
            closeButton.TabIndex = 9;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // selectedMetadataFilePathTextBox
            // 
            selectedMetadataFilePathTextBox.Location = new Point(10, 24);
            selectedMetadataFilePathTextBox.Margin = new Padding(3, 2, 3, 2);
            selectedMetadataFilePathTextBox.Name = "selectedMetadataFilePathTextBox";
            selectedMetadataFilePathTextBox.ReadOnly = true;
            selectedMetadataFilePathTextBox.Size = new Size(860, 23);
            selectedMetadataFilePathTextBox.TabIndex = 43;
            // 
            // selectMetadataFileLabel
            // 
            selectMetadataFileLabel.AutoSize = true;
            selectMetadataFileLabel.Location = new Point(10, 7);
            selectMetadataFileLabel.Name = "selectMetadataFileLabel";
            selectMetadataFileLabel.Size = new Size(115, 15);
            selectMetadataFileLabel.TabIndex = 42;
            selectMetadataFileLabel.Text = "Select Metadata File:";
            // 
            // importMetadataStatusStrip
            // 
            importMetadataStatusStrip.ImageScalingSize = new Size(20, 20);
            importMetadataStatusStrip.Items.AddRange(new ToolStripItem[] { importMetadataStatus, statusLabelDivider, numberOfMetadataImportedStatusLabel, numberOfMetadataImported });
            importMetadataStatusStrip.Location = new Point(0, 489);
            importMetadataStatusStrip.Name = "importMetadataStatusStrip";
            importMetadataStatusStrip.Padding = new Padding(1, 0, 12, 0);
            importMetadataStatusStrip.Size = new Size(1106, 22);
            importMetadataStatusStrip.TabIndex = 45;
            importMetadataStatusStrip.Text = "statusStrip1";
            // 
            // importMetadataStatus
            // 
            importMetadataStatus.Name = "importMetadataStatus";
            importMetadataStatus.Size = new Size(144, 17);
            importMetadataStatus.Text = "No metadata file selected.";
            // 
            // statusLabelDivider
            // 
            statusLabelDivider.Name = "statusLabelDivider";
            statusLabelDivider.Size = new Size(16, 17);
            statusLabelDivider.Text = " | ";
            // 
            // numberOfMetadataImportedStatusLabel
            // 
            numberOfMetadataImportedStatusLabel.Name = "numberOfMetadataImportedStatusLabel";
            numberOfMetadataImportedStatusLabel.Size = new Size(173, 17);
            numberOfMetadataImportedStatusLabel.Text = "Number of metadata imported:";
            // 
            // numberOfMetadataImported
            // 
            numberOfMetadataImported.Name = "numberOfMetadataImported";
            numberOfMetadataImported.Size = new Size(12, 17);
            numberOfMetadataImported.Text = "-";
            // 
            // viewMetadataTemplateButton
            // 
            viewMetadataTemplateButton.Location = new Point(663, 461);
            viewMetadataTemplateButton.Margin = new Padding(3, 2, 3, 2);
            viewMetadataTemplateButton.Name = "viewMetadataTemplateButton";
            viewMetadataTemplateButton.Size = new Size(210, 22);
            viewMetadataTemplateButton.TabIndex = 47;
            viewMetadataTemplateButton.Text = "View Metadata Template";
            viewMetadataTemplateButton.UseVisualStyleBackColor = true;
            // 
            // selectMetadataFileButton
            // 
            selectMetadataFileButton.Location = new Point(875, 24);
            selectMetadataFileButton.Margin = new Padding(3, 2, 3, 2);
            selectMetadataFileButton.Name = "selectMetadataFileButton";
            selectMetadataFileButton.Size = new Size(219, 22);
            selectMetadataFileButton.TabIndex = 44;
            selectMetadataFileButton.Text = "... Select Metadata File (CSV) ...";
            selectMetadataFileButton.UseVisualStyleBackColor = true;
            // 
            // importMetadataDataGridView
            // 
            importMetadataDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            importMetadataDataGridView.Columns.AddRange(new DataGridViewColumn[] { importMetadataDataGridView_itemCol, importMetadataDataGridView_dateCol, importMetadataDataGridView_volumeCol, importMetadataDataGridView_issueCol, importMetadataDataGridView_editionCol, importMetadataDataGridView_pagesCol });
            importMetadataDataGridView.Location = new Point(10, 52);
            importMetadataDataGridView.Name = "importMetadataDataGridView";
            importMetadataDataGridView.Size = new Size(1084, 404);
            importMetadataDataGridView.TabIndex = 48;
            // 
            // importMetadataDataGridView_itemCol
            // 
            importMetadataDataGridView_itemCol.HeaderText = "item";
            importMetadataDataGridView_itemCol.Name = "importMetadataDataGridView_itemCol";
            // 
            // importMetadataDataGridView_dateCol
            // 
            importMetadataDataGridView_dateCol.HeaderText = "date";
            importMetadataDataGridView_dateCol.Name = "importMetadataDataGridView_dateCol";
            // 
            // importMetadataDataGridView_volumeCol
            // 
            importMetadataDataGridView_volumeCol.HeaderText = "volume";
            importMetadataDataGridView_volumeCol.Name = "importMetadataDataGridView_volumeCol";
            // 
            // importMetadataDataGridView_issueCol
            // 
            importMetadataDataGridView_issueCol.HeaderText = "issue";
            importMetadataDataGridView_issueCol.Name = "importMetadataDataGridView_issueCol";
            // 
            // importMetadataDataGridView_editionCol
            // 
            importMetadataDataGridView_editionCol.HeaderText = "edition";
            importMetadataDataGridView_editionCol.Name = "importMetadataDataGridView_editionCol";
            // 
            // importMetadataDataGridView_pagesCol
            // 
            importMetadataDataGridView_pagesCol.HeaderText = "pages";
            importMetadataDataGridView_pagesCol.Name = "importMetadataDataGridView_pagesCol";
            // 
            // ImportMetadataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 511);
            ControlBox = false;
            Controls.Add(importMetadataDataGridView);
            Controls.Add(viewMetadataTemplateButton);
            Controls.Add(importMetadataStatusStrip);
            Controls.Add(selectMetadataFileButton);
            Controls.Add(selectedMetadataFilePathTextBox);
            Controls.Add(selectMetadataFileLabel);
            Controls.Add(closeButton);
            Controls.Add(resetButton);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1122, 550);
            MinimumSize = new Size(1122, 550);
            Name = "ImportMetadataForm";
            Text = "Import Metadata";
            importMetadataStatusStrip.ResumeLayout(false);
            importMetadataStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)importMetadataDataGridView).EndInit();
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
            //selectMetadataFileTextBox.Text = String.Empty;
            selectMetadataFile_openFileDialog.Filter = "Excel Files|*.xls;*.xlsx"; //Only allow Excel files to be selected.
            selectMetadataFile_openFileDialog.FileName = String.Empty;

            //Adjust DataGridView column width:
            //columnMappingDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //columnMappingDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //columnMappingDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //columnMappingDataGridView.Columns[3].Width = 250;

            //Initialize other resources:
            mappedColumnsDict = new Dictionary<string, string>();
            issueMetadata = new Dictionary<string, IssueMetadata>();
        }

        #endregion Custom Initialization
        private Button resetButton;
        private Button closeButton;
        internal TextBox selectedMetadataFilePathTextBox;
        private Label selectMetadataFileLabel;
        private StatusStrip importMetadataStatusStrip;
        private ToolStripStatusLabel numberOfMetadataImportedStatusLabel;
        private ToolStripStatusLabel numberOfMetadataImported;
        private ToolStripStatusLabel importMetadataStatus;
        private ToolStripStatusLabel statusLabelDivider;
        private Button viewMetadataTemplateButton;
        private Button selectMetadataFileButton;
        private DataGridView importMetadataDataGridView;
        private DataGridViewTextBoxColumn importMetadataDataGridView_itemCol;
        private DataGridViewTextBoxColumn importMetadataDataGridView_dateCol;
        private DataGridViewTextBoxColumn importMetadataDataGridView_volumeCol;
        private DataGridViewTextBoxColumn importMetadataDataGridView_issueCol;
        private DataGridViewTextBoxColumn importMetadataDataGridView_editionCol;
        private DataGridViewTextBoxColumn importMetadataDataGridView_pagesCol;
    }
}