using System.Diagnostics;

namespace NewspaperBatchCreation
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
            hideLogsButton = new Button();
            clearLogsButton = new Button();
            saveLogsButton = new Button();
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
            // hideLogsButton
            // 
            hideLogsButton.Location = new Point(874, 615);
            hideLogsButton.Name = "hideLogsButton";
            hideLogsButton.Size = new Size(120, 29);
            hideLogsButton.TabIndex = 1;
            hideLogsButton.Text = "Hide Logs";
            hideLogsButton.UseVisualStyleBackColor = true;
            // 
            // clearLogsButton
            // 
            clearLogsButton.Location = new Point(748, 615);
            clearLogsButton.Name = "clearLogsButton";
            clearLogsButton.Size = new Size(120, 29);
            clearLogsButton.TabIndex = 2;
            clearLogsButton.Text = "Clear Logs";
            clearLogsButton.UseVisualStyleBackColor = true;
            clearLogsButton.Click += clearLogsButton_Click;
            // 
            // saveLogsButton
            // 
            saveLogsButton.Location = new Point(622, 615);
            saveLogsButton.Name = "saveLogsButton";
            saveLogsButton.Size = new Size(120, 29);
            saveLogsButton.TabIndex = 3;
            saveLogsButton.Text = "Save Logs";
            saveLogsButton.UseVisualStyleBackColor = true;
            // 
            // pauseLogMonitoringCheckbox
            // 
            pauseLogMonitoringCheckbox.AutoSize = true;
            pauseLogMonitoringCheckbox.Location = new Point(12, 615);
            pauseLogMonitoringCheckbox.Name = "pauseLogMonitoringCheckbox";
            pauseLogMonitoringCheckbox.Size = new Size(175, 24);
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
            logEntryDataGridView.Location = new Point(12, 12);
            logEntryDataGridView.Name = "logEntryDataGridView";
            logEntryDataGridView.RowHeadersWidth = 51;
            logEntryDataGridView.Size = new Size(982, 595);
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
            logFormStatusStrip.Location = new Point(0, 647);
            logFormStatusStrip.Name = "logFormStatusStrip";
            logFormStatusStrip.Size = new Size(1006, 26);
            logFormStatusStrip.TabIndex = 6;
            logFormStatusStrip.Text = "logFormStatusStrip";
            // 
            // maxLogEntryStatusStripLabel
            // 
            maxLogEntryStatusStripLabel.Name = "maxLogEntryStatusStripLabel";
            maxLogEntryStatusStripLabel.Size = new Size(294, 20);
            maxLogEntryStatusStripLabel.Text = "Only the most recent log entries are shown.";
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 673);
            ControlBox = false;
            Controls.Add(logFormStatusStrip);
            Controls.Add(logEntryDataGridView);
            Controls.Add(pauseLogMonitoringCheckbox);
            Controls.Add(saveLogsButton);
            Controls.Add(clearLogsButton);
            Controls.Add(hideLogsButton);
            MaximumSize = new Size(1024, 720);
            MinimumSize = new Size(1024, 720);
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
        internal static readonly int INFO = 0, WARN = 1, ERROR = 2, DEBUG = 3;
        internal static readonly Dictionary<int, string> LogType = new Dictionary<int, string>
        {
            { INFO, "[INFO]" },
            { WARN, "[WARN]" },
            { ERROR, "[ERROR]"},
            { DEBUG, "[DEBUG]"}
        };

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

        private Button hideLogsButton;
        private Button clearLogsButton;
        private Button saveLogsButton;
        private CheckBox pauseLogMonitoringCheckbox;
        private DataGridView logEntryDataGridView;
        private DataGridViewTextBoxColumn logTimestampCol;
        private DataGridViewTextBoxColumn logTypeCol;
        private DataGridViewTextBoxColumn logMessageCol;
        private StatusStrip logFormStatusStrip;
        private ToolStripStatusLabel maxLogEntryStatusStripLabel;
    }
}