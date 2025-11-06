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
            settingsStatusStrip = new StatusStrip();
            saveButton = new Button();
            settingsTabControl = new TabControl();
            applicationAndBatchSettingsTab = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            manageTitlesTab = new TabPage();
            manageTitlesDataGridView = new DataGridView();
            selectLccnComboBox = new ComboBox();
            settingsTabControl.SuspendLayout();
            applicationAndBatchSettingsTab.SuspendLayout();
            manageTitlesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)manageTitlesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Location = new Point(989, 464);
            closeButton.Margin = new Padding(3, 2, 3, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(105, 22);
            closeButton.TabIndex = 33;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += saveAndCloseButton_Click;
            // 
            // settingsStatusStrip
            // 
            settingsStatusStrip.ImageScalingSize = new Size(20, 20);
            settingsStatusStrip.Location = new Point(0, 489);
            settingsStatusStrip.Name = "settingsStatusStrip";
            settingsStatusStrip.Padding = new Padding(1, 0, 12, 0);
            settingsStatusStrip.Size = new Size(1106, 22);
            settingsStatusStrip.TabIndex = 47;
            settingsStatusStrip.Text = "statusStrip1";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(878, 464);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(105, 22);
            saveButton.TabIndex = 54;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // settingsTabControl
            // 
            settingsTabControl.Controls.Add(applicationAndBatchSettingsTab);
            settingsTabControl.Controls.Add(manageTitlesTab);
            settingsTabControl.Location = new Point(12, 12);
            settingsTabControl.Name = "settingsTabControl";
            settingsTabControl.SelectedIndex = 0;
            settingsTabControl.Size = new Size(1082, 447);
            settingsTabControl.TabIndex = 55;
            // 
            // applicationAndBatchSettingsTab
            // 
            applicationAndBatchSettingsTab.Controls.Add(tableLayoutPanel1);
            applicationAndBatchSettingsTab.Location = new Point(4, 24);
            applicationAndBatchSettingsTab.Name = "applicationAndBatchSettingsTab";
            applicationAndBatchSettingsTab.Padding = new Padding(3);
            applicationAndBatchSettingsTab.Size = new Size(1074, 419);
            applicationAndBatchSettingsTab.TabIndex = 0;
            applicationAndBatchSettingsTab.Text = "Application and Batch Settings";
            applicationAndBatchSettingsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(1062, 407);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // manageTitlesTab
            // 
            manageTitlesTab.Controls.Add(manageTitlesDataGridView);
            manageTitlesTab.Location = new Point(4, 24);
            manageTitlesTab.Name = "manageTitlesTab";
            manageTitlesTab.Padding = new Padding(3);
            manageTitlesTab.Size = new Size(1074, 419);
            manageTitlesTab.TabIndex = 1;
            manageTitlesTab.Text = "Manage Titles";
            manageTitlesTab.UseVisualStyleBackColor = true;
            // 
            // manageTitlesDataGridView
            // 
            manageTitlesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            manageTitlesDataGridView.Location = new Point(6, 34);
            manageTitlesDataGridView.Margin = new Padding(3, 2, 3, 2);
            manageTitlesDataGridView.Name = "manageTitlesDataGridView";
            manageTitlesDataGridView.RowHeadersWidth = 51;
            manageTitlesDataGridView.Size = new Size(1062, 380);
            manageTitlesDataGridView.TabIndex = 56;
            // 
            // selectLccnComboBox
            // 
            selectLccnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectLccnComboBox.FormattingEnabled = true;
            selectLccnComboBox.Items.AddRange(new object[] { "Select LCCN ..." });
            selectLccnComboBox.Location = new Point(940, 7);
            selectLccnComboBox.Name = "selectLccnComboBox";
            selectLccnComboBox.Size = new Size(150, 23);
            selectLccnComboBox.TabIndex = 57;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 511);
            ControlBox = false;
            Controls.Add(selectLccnComboBox);
            Controls.Add(settingsTabControl);
            Controls.Add(saveButton);
            Controls.Add(settingsStatusStrip);
            Controls.Add(closeButton);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1122, 550);
            MinimumSize = new Size(1122, 550);
            Name = "SettingsForm";
            Text = "Settings";
            settingsTabControl.ResumeLayout(false);
            applicationAndBatchSettingsTab.ResumeLayout(false);
            manageTitlesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)manageTitlesDataGridView).EndInit();
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

            selectLccnComboBox.SelectedIndex = 0;
            selectLccnComboBox.Visible = false;
            settingsTabControl.SelectedIndexChanged += settingsTabControl_SelectedIndexChanged;

            //outputFolderTextBox.Text = Properties.Settings.Default.OutputFolder;
            //batchTypeComboBox.SelectedIndex = 0;
        }

        #endregion Custom Initializations

        private Button closeButton;
        internal FolderBrowserDialog selectMetadataFile_folderBrowserDialog;
        private StatusStrip settingsStatusStrip;
        private Button saveButton;
        private TabControl settingsTabControl;
        private TabPage applicationAndBatchSettingsTab;
        private TabPage manageTitlesTab;
        private DataGridView manageTitlesDataGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox selectLccnComboBox;
    }
}