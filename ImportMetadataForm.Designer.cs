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
            saveAndCloseButton = new Button();
            startOverButton = new Button();
            selectMetadataFile_openFileDialog = new OpenFileDialog();
            selectmetadataFileTextBox = new TextBox();
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
            // saveAndCloseButton
            // 
            saveAndCloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveAndCloseButton.Location = new Point(1070, 632);
            saveAndCloseButton.Name = "saveAndCloseButton";
            saveAndCloseButton.Size = new Size(180, 29);
            saveAndCloseButton.TabIndex = 0;
            saveAndCloseButton.Text = "Save and Close";
            saveAndCloseButton.UseVisualStyleBackColor = true;
            saveAndCloseButton.Click += exitButton_Click;
            // 
            // startOverButton
            // 
            startOverButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            startOverButton.Location = new Point(884, 632);
            startOverButton.Name = "startOverButton";
            startOverButton.Size = new Size(180, 29);
            startOverButton.TabIndex = 1;
            startOverButton.Text = "Start Over";
            startOverButton.UseVisualStyleBackColor = true;
            // 
            // selectMetadataFile_openFileDialog
            // 
            selectMetadataFile_openFileDialog.FileName = "openFileDialog1";
            // 
            // selectmetadataFileTextBox
            // 
            selectmetadataFileTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectmetadataFileTextBox.Location = new Point(12, 32);
            selectmetadataFileTextBox.Name = "selectmetadataFileTextBox";
            selectmetadataFileTextBox.ReadOnly = true;
            selectmetadataFileTextBox.Size = new Size(1052, 27);
            selectmetadataFileTextBox.TabIndex = 2;
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
            columnMappingDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            columnMappingDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            columnMappingDataGridView.Columns.AddRange(new DataGridViewColumn[] { columnNumberCol, columnHeaderCol, sampleDataCol, mapToCol });
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
            Controls.Add(columnMappingLabel);
            Controls.Add(columnMappingDataGridView);
            Controls.Add(selectMetadataFileButton);
            Controls.Add(selectMetadataFileLabel);
            Controls.Add(selectmetadataFileTextBox);
            Controls.Add(startOverButton);
            Controls.Add(saveAndCloseButton);
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

        private void CustomInitialization()
        {
            selectmetadataFileTextBox.Text = String.Empty;
            selectMetadataFile_openFileDialog.Filter = "Excel Files|*.xls;*.xlsx|All files (*.*)|*.*";
        }

        #endregion Custom Initialization

        private Button saveAndCloseButton;
        private Button startOverButton;
        private OpenFileDialog selectMetadataFile_openFileDialog;
        private TextBox selectmetadataFileTextBox;
        private Label selectMetadataFileLabel;
        private Button selectMetadataFileButton;
        private DataGridView columnMappingDataGridView;
        private Label columnMappingLabel;
        private DataGridViewTextBoxColumn columnNumberCol;
        private DataGridViewTextBoxColumn columnHeaderCol;
        private DataGridViewTextBoxColumn sampleDataCol;
        private DataGridViewComboBoxColumn mapToCol;
    }
}