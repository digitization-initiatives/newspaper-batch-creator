using NewspaperBatchCreator.src;
using System.Collections.Generic;

namespace NewspaperBatchCreator
{
    partial class ImportEditMetadataForm
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
            importViaCSV_openFileDialog = new OpenFileDialog();
            importEditMetadataStatusStrip = new StatusStrip();
            importMetadataStatus = new ToolStripStatusLabel();
            statusLabelDivider = new ToolStripStatusLabel();
            numberOfMetadataImportedStatusLabel = new ToolStripStatusLabel();
            numberOfMetadataImported = new ToolStripStatusLabel();
            importViaCSVButton = new Button();
            viewOrEditMetadataDataGridView = new DataGridView();
            viewOrEditMetadataDataGridView_itemCol = new DataGridViewTextBoxColumn();
            viewOrEditMetadataDataGridView_dateCol = new DataGridViewTextBoxColumn();
            viewOrEditMetadataDataGridView_volumeCol = new DataGridViewTextBoxColumn();
            viewOrEditMetadataDataGridView_issueCol = new DataGridViewTextBoxColumn();
            viewOrEditMetadataDataGridView_editionCol = new DataGridViewTextBoxColumn();
            viewOrEditMetadataDataGridView_pagesCol = new DataGridViewTextBoxColumn();
            viewEditLabel = new Label();
            closeButton = new Button();
            resetButton = new Button();
            saveButton = new Button();
            importEditMetadataStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewOrEditMetadataDataGridView).BeginInit();
            SuspendLayout();
            // 
            // importViaCSV_openFileDialog
            // 
            importViaCSV_openFileDialog.FileName = "openFileDialog1";
            // 
            // importEditMetadataStatusStrip
            // 
            importEditMetadataStatusStrip.ImageScalingSize = new Size(20, 20);
            importEditMetadataStatusStrip.Items.AddRange(new ToolStripItem[] { importMetadataStatus, statusLabelDivider, numberOfMetadataImportedStatusLabel, numberOfMetadataImported });
            importEditMetadataStatusStrip.Location = new Point(0, 489);
            importEditMetadataStatusStrip.Name = "importEditMetadataStatusStrip";
            importEditMetadataStatusStrip.Padding = new Padding(1, 0, 12, 0);
            importEditMetadataStatusStrip.Size = new Size(1106, 22);
            importEditMetadataStatusStrip.TabIndex = 45;
            importEditMetadataStatusStrip.Text = "statusStrip1";
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
            // importViaCSVButton
            // 
            importViaCSVButton.Location = new Point(626, 12);
            importViaCSVButton.Margin = new Padding(3, 2, 3, 2);
            importViaCSVButton.Name = "importViaCSVButton";
            importViaCSVButton.Size = new Size(150, 23);
            importViaCSVButton.TabIndex = 44;
            importViaCSVButton.Text = "... Import Via CSV ...";
            importViaCSVButton.UseVisualStyleBackColor = true;
            importViaCSVButton.Click += importViaCSVButton_Click;
            // 
            // viewOrEditMetadataDataGridView
            // 
            viewOrEditMetadataDataGridView.BackgroundColor = Color.White;
            viewOrEditMetadataDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewOrEditMetadataDataGridView.Columns.AddRange(new DataGridViewColumn[] { viewOrEditMetadataDataGridView_itemCol, viewOrEditMetadataDataGridView_dateCol, viewOrEditMetadataDataGridView_volumeCol, viewOrEditMetadataDataGridView_issueCol, viewOrEditMetadataDataGridView_editionCol, viewOrEditMetadataDataGridView_pagesCol });
            viewOrEditMetadataDataGridView.Location = new Point(10, 41);
            viewOrEditMetadataDataGridView.Name = "viewOrEditMetadataDataGridView";
            viewOrEditMetadataDataGridView.ScrollBars = ScrollBars.Vertical;
            viewOrEditMetadataDataGridView.Size = new Size(1084, 440);
            viewOrEditMetadataDataGridView.TabIndex = 48;
            // 
            // viewOrEditMetadataDataGridView_itemCol
            // 
            viewOrEditMetadataDataGridView_itemCol.HeaderText = "item";
            viewOrEditMetadataDataGridView_itemCol.Name = "viewOrEditMetadataDataGridView_itemCol";
            viewOrEditMetadataDataGridView_itemCol.Width = 350;
            // 
            // viewOrEditMetadataDataGridView_dateCol
            // 
            viewOrEditMetadataDataGridView_dateCol.HeaderText = "date";
            viewOrEditMetadataDataGridView_dateCol.Name = "viewOrEditMetadataDataGridView_dateCol";
            viewOrEditMetadataDataGridView_dateCol.Width = 250;
            // 
            // viewOrEditMetadataDataGridView_volumeCol
            // 
            viewOrEditMetadataDataGridView_volumeCol.HeaderText = "volume";
            viewOrEditMetadataDataGridView_volumeCol.Name = "viewOrEditMetadataDataGridView_volumeCol";
            viewOrEditMetadataDataGridView_volumeCol.Width = 120;
            // 
            // viewOrEditMetadataDataGridView_issueCol
            // 
            viewOrEditMetadataDataGridView_issueCol.HeaderText = "issue";
            viewOrEditMetadataDataGridView_issueCol.Name = "viewOrEditMetadataDataGridView_issueCol";
            viewOrEditMetadataDataGridView_issueCol.Width = 120;
            // 
            // viewOrEditMetadataDataGridView_editionCol
            // 
            viewOrEditMetadataDataGridView_editionCol.HeaderText = "edition";
            viewOrEditMetadataDataGridView_editionCol.Name = "viewOrEditMetadataDataGridView_editionCol";
            viewOrEditMetadataDataGridView_editionCol.Width = 120;
            // 
            // viewOrEditMetadataDataGridView_pagesCol
            // 
            viewOrEditMetadataDataGridView_pagesCol.HeaderText = "pages";
            viewOrEditMetadataDataGridView_pagesCol.Name = "viewOrEditMetadataDataGridView_pagesCol";
            viewOrEditMetadataDataGridView_pagesCol.Width = 120;
            // 
            // viewEditLabel
            // 
            viewEditLabel.AutoSize = true;
            viewEditLabel.Location = new Point(12, 16);
            viewEditLabel.Name = "viewEditLabel";
            viewEditLabel.Size = new Size(75, 15);
            viewEditLabel.TabIndex = 49;
            viewEditLabel.Text = "View or Edit :";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(994, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(100, 23);
            closeButton.TabIndex = 50;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(782, 12);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(100, 23);
            resetButton.TabIndex = 51;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(888, 12);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 23);
            saveButton.TabIndex = 52;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // ImportEditMetadataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 511);
            ControlBox = false;
            Controls.Add(saveButton);
            Controls.Add(resetButton);
            Controls.Add(closeButton);
            Controls.Add(viewEditLabel);
            Controls.Add(viewOrEditMetadataDataGridView);
            Controls.Add(importEditMetadataStatusStrip);
            Controls.Add(importViaCSVButton);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1122, 550);
            MinimumSize = new Size(1122, 550);
            Name = "ImportEditMetadataForm";
            Text = "Import/Edit Metadata";
            importEditMetadataStatusStrip.ResumeLayout(false);
            importEditMetadataStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewOrEditMetadataDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Initialization

        private MainForm mainForm;
        private LogForm logForm;
        private Utilities utilities;
        
        private OpenFileDialog importViaCSV_openFileDialog;

        string metadataCsvFilePath;
        private void CustomInitialization()
        {
            //Custom form start location:
            this.StartPosition = FormStartPosition.Manual;

            //Add clear selection when MouseDown:
            this.MouseDown += ImportEditMetadataForm_MouseDown;

            //Initialize openFileDialog:
            importViaCSV_openFileDialog.Filter = "CSV Files|*.csv";
            importViaCSV_openFileDialog.Title = "Import Via CSV";
            importViaCSV_openFileDialog.FileName = String.Empty;
            metadataCsvFilePath = String.Empty;

            //Initialize Utilities:
            utilities = new Utilities(this.logForm);

            //Initialize viewOrEditMetadataDataGridView:
            viewOrEditMetadataDataGridView.Columns[0].Width = 450; //item
            viewOrEditMetadataDataGridView.Columns[1].Width = 250; //date

            int lastFourColumnsWidth = (viewOrEditMetadataDataGridView.Width - 751) / 4;
            viewOrEditMetadataDataGridView.Columns[2].Width = lastFourColumnsWidth; //volume
            viewOrEditMetadataDataGridView.Columns[3].Width = lastFourColumnsWidth; //issue
            viewOrEditMetadataDataGridView.Columns[4].Width = lastFourColumnsWidth; //edition
            viewOrEditMetadataDataGridView.Columns[5].Width = lastFourColumnsWidth; //pages

            viewOrEditMetadataDataGridView.MouseDown += viewOrEditMetadataDataGridView_MouseDown;
        }

        #endregion Custom Initialization
        private StatusStrip importEditMetadataStatusStrip;
        private ToolStripStatusLabel numberOfMetadataImportedStatusLabel;
        private ToolStripStatusLabel numberOfMetadataImported;
        private ToolStripStatusLabel importMetadataStatus;
        private ToolStripStatusLabel statusLabelDivider;
        private Button importViaCSVButton;
        private DataGridView viewOrEditMetadataDataGridView;
        private Label viewEditLabel;
        private Button closeButton;
        private Button resetButton;
        private Button saveButton;
        private DataGridViewTextBoxColumn viewOrEditMetadataDataGridView_itemCol;
        private DataGridViewTextBoxColumn viewOrEditMetadataDataGridView_dateCol;
        private DataGridViewTextBoxColumn viewOrEditMetadataDataGridView_volumeCol;
        private DataGridViewTextBoxColumn viewOrEditMetadataDataGridView_issueCol;
        private DataGridViewTextBoxColumn viewOrEditMetadataDataGridView_editionCol;
        private DataGridViewTextBoxColumn viewOrEditMetadataDataGridView_pagesCol;
    }
}