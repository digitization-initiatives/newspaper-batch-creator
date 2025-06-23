using NewspaperBatchAssemblyTool.src;
using System.Collections.Generic;

namespace NewspaperBatchAssemblyTool
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
            importAndCloseButton = new Button();
            startOverButton = new Button();
            selectMetadataFile_openFileDialog = new OpenFileDialog();
            selectMetadataFileTextBox = new TextBox();
            selectMetadataFileLabel = new Label();
            selectMetadataFileButton = new Button();
            columnMappingDataGridView = new DataGridView();
            columnNumberCol = new DataGridViewTextBoxColumn();
            columnHeaderCol = new DataGridViewTextBoxColumn();
            sampleDataCol = new DataGridViewTextBoxColumn();
            mapToCol = new DataGridViewComboBoxColumn();
            columnMappingLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)columnMappingDataGridView).BeginInit();
            SuspendLayout();
            // 
            // importAndCloseButton
            // 
            importAndCloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            importAndCloseButton.Location = new Point(1000, 632);
            importAndCloseButton.Name = "importAndCloseButton";
            importAndCloseButton.Size = new Size(250, 29);
            importAndCloseButton.TabIndex = 0;
            importAndCloseButton.Text = "Import Metadata and Close";
            importAndCloseButton.UseVisualStyleBackColor = true;
            importAndCloseButton.Click += exitButton_Click;
            // 
            // startOverButton
            // 
            startOverButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            startOverButton.Location = new Point(814, 632);
            startOverButton.Name = "startOverButton";
            startOverButton.Size = new Size(180, 29);
            startOverButton.TabIndex = 1;
            startOverButton.Text = "Start Over";
            startOverButton.UseVisualStyleBackColor = true;
            startOverButton.Click += startOverButton_Click;
            // 
            // selectMetadataFile_openFileDialog
            // 
            selectMetadataFile_openFileDialog.FileName = "openFileDialog1";
            // 
            // selectMetadataFileTextBox
            // 
            selectMetadataFileTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectMetadataFileTextBox.Location = new Point(12, 32);
            selectMetadataFileTextBox.Name = "selectMetadataFileTextBox";
            selectMetadataFileTextBox.ReadOnly = true;
            selectMetadataFileTextBox.Size = new Size(1052, 27);
            selectMetadataFileTextBox.TabIndex = 2;
            // 
            // selectMetadataFileLabel
            // 
            selectMetadataFileLabel.AutoSize = true;
            selectMetadataFileLabel.Location = new Point(12, 9);
            selectMetadataFileLabel.Name = "selectMetadataFileLabel";
            selectMetadataFileLabel.Size = new Size(147, 20);
            selectMetadataFileLabel.TabIndex = 3;
            selectMetadataFileLabel.Text = "Select Metadata File:";
            // 
            // selectMetadataFileButton
            // 
            selectMetadataFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectMetadataFileButton.Location = new Point(1070, 31);
            selectMetadataFileButton.Name = "selectMetadataFileButton";
            selectMetadataFileButton.Size = new Size(180, 29);
            selectMetadataFileButton.TabIndex = 4;
            selectMetadataFileButton.Text = "... Select File ...";
            selectMetadataFileButton.UseVisualStyleBackColor = true;
            selectMetadataFileButton.Click += selectMetadataFileButton_Click;
            // 
            // columnMappingDataGridView
            // 
            columnMappingDataGridView.AllowUserToAddRows = false;
            columnMappingDataGridView.AllowUserToDeleteRows = false;
            columnMappingDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            columnMappingDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            columnMappingDataGridView.Columns.AddRange(new DataGridViewColumn[] { columnNumberCol, columnHeaderCol, sampleDataCol, mapToCol });
            columnMappingDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            columnMappingDataGridView.Location = new Point(12, 102);
            columnMappingDataGridView.Name = "columnMappingDataGridView";
            columnMappingDataGridView.RowHeadersWidth = 51;
            columnMappingDataGridView.Size = new Size(1238, 515);
            columnMappingDataGridView.TabIndex = 5;
            // 
            // columnNumberCol
            // 
            columnNumberCol.HeaderText = "Column Number";
            columnNumberCol.MinimumWidth = 6;
            columnNumberCol.Name = "columnNumberCol";
            columnNumberCol.Width = 125;
            // 
            // columnHeaderCol
            // 
            columnHeaderCol.HeaderText = "Column Header";
            columnHeaderCol.MinimumWidth = 6;
            columnHeaderCol.Name = "columnHeaderCol";
            columnHeaderCol.Width = 125;
            // 
            // sampleDataCol
            // 
            sampleDataCol.HeaderText = "Sample Data";
            sampleDataCol.MinimumWidth = 6;
            sampleDataCol.Name = "sampleDataCol";
            sampleDataCol.Width = 125;
            // 
            // mapToCol
            // 
            mapToCol.HeaderText = "Map To:";
            mapToCol.Items.AddRange(new object[] { "ISSUE_NUMBER", "TITLE", "DESCRIPTION", "DATE", "VOLUME", "FREQUENCY", "NUMBER_OF_PAGES", "DC_SUBJECT_INSTITUTION", "DC_SUBJECT_COLLEGE", "DC_SUBJECT_LOCATION", "DC_CONTRIBUTOR_COLLEGE", "DC_CONTRIBUTOR_INSTITUTION", "DC_COVERAGE", "DC_PUBLISHER", "DC_LANGUAGE", "DC_FORMAT", "DC_TYPE", "DC_RIGHTS" });
            mapToCol.MinimumWidth = 6;
            mapToCol.Name = "mapToCol";
            mapToCol.Width = 125;
            // 
            // columnMappingLabel
            // 
            columnMappingLabel.AutoSize = true;
            columnMappingLabel.Location = new Point(12, 79);
            columnMappingLabel.Name = "columnMappingLabel";
            columnMappingLabel.Size = new Size(127, 20);
            columnMappingLabel.TabIndex = 6;
            columnMappingLabel.Text = "Column Mapping:";
            // 
            // ImportMetadataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            ControlBox = false;
            Controls.Add(columnMappingLabel);
            Controls.Add(columnMappingDataGridView);
            Controls.Add(selectMetadataFileButton);
            Controls.Add(selectMetadataFileLabel);
            Controls.Add(selectMetadataFileTextBox);
            Controls.Add(startOverButton);
            Controls.Add(importAndCloseButton);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "ImportMetadataForm";
            Text = "Import Metadata";
            ((System.ComponentModel.ISupportInitialize)columnMappingDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Initialization

        private MainForm mainForm;
        public LogForm logForm;

        public DataGridView columnMappingDataGridView;
        public OpenFileDialog selectMetadataFile_openFileDialog;
        public TextBox selectMetadataFileTextBox;

        public Dictionary<string, string> mappedColumnsDict;

        public Dictionary<string, IssueMetadata> issueMetadata;

        private void CustomInitialization()
        {
            //Custom form start location:
            this.StartPosition = FormStartPosition.Manual;



            selectMetadataFileTextBox.Text = String.Empty;
            selectMetadataFile_openFileDialog.Filter = "Excel Files|*.xls;*.xlsx|All files (*.*)|*.*";

            columnMappingDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnMappingDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnMappingDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnMappingDataGridView.Columns[3].Width = 250;

            mappedColumnsDict = new Dictionary<string, string>();
            issueMetadata = new Dictionary<string, IssueMetadata>();
        }

        #endregion Custom Initialization

        private Button importAndCloseButton;
        private Button startOverButton;
        private Label selectMetadataFileLabel;
        private Button selectMetadataFileButton;
        private Label columnMappingLabel;
        private DataGridViewTextBoxColumn columnNumberCol;
        private DataGridViewTextBoxColumn columnHeaderCol;
        private DataGridViewTextBoxColumn sampleDataCol;
        private DataGridViewComboBoxColumn mapToCol;
    }
}