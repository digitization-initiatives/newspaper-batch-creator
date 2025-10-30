using System.Diagnostics;

namespace NewspaperBatchCreator
{
    partial class LogForm
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
            hideButton = new Button();
            clearButton = new Button();
            viewFullLogsButton = new Button();
            pauseLogMonitoringCheckbox = new CheckBox();
            logEntryDataGridView = new DataGridView();
            logTimestampCol = new DataGridViewTextBoxColumn();
            logTypeCol = new DataGridViewTextBoxColumn();
            logMessageCol = new DataGridViewTextBoxColumn();
            logFormStatusStrip = new StatusStrip();
            maxLogEntryStatusStripLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)logEntryDataGridView).BeginInit();
            logFormStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // hideButton
            // 
            hideButton.Location = new Point(765, 461);
            hideButton.Margin = new Padding(3, 2, 3, 2);
            hideButton.Name = "hideButton";
            hideButton.Size = new Size(105, 22);
            hideButton.TabIndex = 1;
            hideButton.Text = "Hide";
            hideButton.UseVisualStyleBackColor = true;
            hideButton.Click += hideButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(654, 461);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(105, 22);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // viewFullLogsButton
            // 
            viewFullLogsButton.Location = new Point(528, 461);
            viewFullLogsButton.Margin = new Padding(3, 2, 3, 2);
            viewFullLogsButton.Name = "viewFullLogsButton";
            viewFullLogsButton.Size = new Size(120, 22);
            viewFullLogsButton.TabIndex = 3;
            viewFullLogsButton.Text = "View Full Logs";
            viewFullLogsButton.UseVisualStyleBackColor = true;
            viewFullLogsButton.Click += viewFullLogsButton_Click;
            // 
            // pauseLogMonitoringCheckbox
            // 
            pauseLogMonitoringCheckbox.AutoSize = true;
            pauseLogMonitoringCheckbox.Location = new Point(10, 461);
            pauseLogMonitoringCheckbox.Margin = new Padding(3, 2, 3, 2);
            pauseLogMonitoringCheckbox.Name = "pauseLogMonitoringCheckbox";
            pauseLogMonitoringCheckbox.Size = new Size(143, 19);
            pauseLogMonitoringCheckbox.TabIndex = 4;
            pauseLogMonitoringCheckbox.Text = "Pause Log Monitoring";
            pauseLogMonitoringCheckbox.UseVisualStyleBackColor = true;
            // 
            // logEntryDataGridView
            // 
            logEntryDataGridView.AllowUserToAddRows = false;
            logEntryDataGridView.AllowUserToDeleteRows = false;
            logEntryDataGridView.AllowUserToResizeColumns = false;
            logEntryDataGridView.AllowUserToResizeRows = false;
            logEntryDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logEntryDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            logEntryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            logEntryDataGridView.Columns.AddRange(new DataGridViewColumn[] { logTimestampCol, logTypeCol, logMessageCol });
            logEntryDataGridView.Location = new Point(10, 9);
            logEntryDataGridView.Margin = new Padding(3, 2, 3, 2);
            logEntryDataGridView.Name = "logEntryDataGridView";
            logEntryDataGridView.RowHeadersWidth = 51;
            logEntryDataGridView.Size = new Size(859, 448);
            logEntryDataGridView.TabIndex = 5;
            // 
            // logTimestampCol
            // 
            logTimestampCol.HeaderText = "Timestamp";
            logTimestampCol.MinimumWidth = 6;
            logTimestampCol.Name = "logTimestampCol";
            logTimestampCol.Width = 125;
            // 
            // logTypeCol
            // 
            logTypeCol.HeaderText = "Type";
            logTypeCol.MinimumWidth = 6;
            logTypeCol.Name = "logTypeCol";
            logTypeCol.Width = 125;
            // 
            // logMessageCol
            // 
            logMessageCol.HeaderText = "Log Message";
            logMessageCol.MinimumWidth = 6;
            logMessageCol.Name = "logMessageCol";
            logMessageCol.Width = 125;
            // 
            // logFormStatusStrip
            // 
            logFormStatusStrip.ImageScalingSize = new Size(20, 20);
            logFormStatusStrip.Items.AddRange(new ToolStripItem[] { maxLogEntryStatusStripLabel });
            logFormStatusStrip.Location = new Point(0, 489);
            logFormStatusStrip.Name = "logFormStatusStrip";
            logFormStatusStrip.Padding = new Padding(1, 0, 12, 0);
            logFormStatusStrip.Size = new Size(882, 22);
            logFormStatusStrip.TabIndex = 6;
            logFormStatusStrip.Text = "logFormStatusStrip";
            // 
            // maxLogEntryStatusStripLabel
            // 
            maxLogEntryStatusStripLabel.Name = "maxLogEntryStatusStripLabel";
            maxLogEntryStatusStripLabel.Size = new Size(257, 17);
            maxLogEntryStatusStripLabel.Text = "Only the most recent 500 log entries are shown.";
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 511);
            ControlBox = false;
            Controls.Add(logFormStatusStrip);
            Controls.Add(logEntryDataGridView);
            Controls.Add(pauseLogMonitoringCheckbox);
            Controls.Add(viewFullLogsButton);
            Controls.Add(clearButton);
            Controls.Add(hideButton);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(898, 550);
            MinimumSize = new Size(898, 550);
            Name = "LogForm";
            Text = "View Logs";
            ((System.ComponentModel.ISupportInitialize)logEntryDataGridView).EndInit();
            logFormStatusStrip.ResumeLayout(false);
            logFormStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Initialization

        //Override default OnShown behavior:
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.ActiveControl = null;
        }

        internal MainForm mainForm;

        internal static readonly int MAX_LOG_ROWS = 500;
        internal static readonly (string INFO, string WARN, string ERROR, string DEBUG) LogType = ("[INFO]", "[WARN]", "[ERROR]", "[DEBUG]");

        internal string logFileName = String.Empty;
        internal string logFileFullPath = String.Empty;

        private void CustomInitialization()
        {
            this.Click += LogForm_Click;

            // Set log monitoring window column size:
            logTimestampCol.Width = 150;
            logTypeCol.Width = 60;
            logMessageCol.Width = logEntryDataGridView.Width - logTimestampCol.Width - logTypeCol.Width - 3;

            // Define cell text alignment:
            logTimestampCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            logTypeCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            logMessageCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;


            maxLogEntryStatusStripLabel.Text = $"Only the most recent {MAX_LOG_ROWS} log entries are shown.";

            // Initialize log file:
            Properties.Settings.Default.LogLocation = Path.GetFullPath(".") + "\\logs";

            logFileName = $"ocr_{DateTime.Now:yyyyMMdd_HHmmss}.log";
            logFileFullPath = Path.Combine(Properties.Settings.Default.LogLocation, logFileName);

            if (!Directory.Exists(Properties.Settings.Default.LogLocation))
            {
                Directory.CreateDirectory(Properties.Settings.Default.LogLocation);
            }

            File.WriteAllText(logFileFullPath, String.Empty);
        }

        #endregion

        private Button hideButton;
        private Button clearButton;
        private Button viewFullLogsButton;
        private CheckBox pauseLogMonitoringCheckbox;
        private DataGridView logEntryDataGridView;
        private DataGridViewTextBoxColumn logTimestampCol;
        private DataGridViewTextBoxColumn logTypeCol;
        private DataGridViewTextBoxColumn logMessageCol;
        private StatusStrip logFormStatusStrip;
        private ToolStripStatusLabel maxLogEntryStatusStripLabel;
    }
}