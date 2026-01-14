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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            hideButton = new Button();
            clearButton = new Button();
            viewFullLogsButton = new Button();
            pauseLogMonitoringCheckbox = new CheckBox();
            logFormStatusStrip = new StatusStrip();
            maxLogEntryStatusStripLabel = new ToolStripStatusLabel();
            logEntryDataGridView = new DataGridView();
            logTimestampCol = new DataGridViewTextBoxColumn();
            logTypeCol = new DataGridViewTextBoxColumn();
            logMessageCol = new DataGridViewTextBoxColumn();
            logFormStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logEntryDataGridView).BeginInit();
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
            // logEntryDataGridView
            // 
            logEntryDataGridView.AllowUserToAddRows = false;
            logEntryDataGridView.AllowUserToDeleteRows = false;
            logEntryDataGridView.AllowUserToResizeColumns = false;
            logEntryDataGridView.AllowUserToResizeRows = false;
            logEntryDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            logEntryDataGridView.BackgroundColor = Color.White;
            logEntryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            logEntryDataGridView.Columns.AddRange(new DataGridViewColumn[] { logTimestampCol, logTypeCol, logMessageCol });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            logEntryDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            logEntryDataGridView.Location = new Point(10, 12);
            logEntryDataGridView.Name = "logEntryDataGridView";
            logEntryDataGridView.ReadOnly = true;
            logEntryDataGridView.ScrollBars = ScrollBars.Vertical;
            logEntryDataGridView.Size = new Size(860, 444);
            logEntryDataGridView.TabIndex = 7;
            // 
            // logTimestampCol
            // 
            logTimestampCol.HeaderText = "Timestamp";
            logTimestampCol.Name = "logTimestampCol";
            logTimestampCol.ReadOnly = true;
            // 
            // logTypeCol
            // 
            logTypeCol.HeaderText = "Type";
            logTypeCol.Name = "logTypeCol";
            logTypeCol.ReadOnly = true;
            // 
            // logMessageCol
            // 
            logMessageCol.HeaderText = "Log Message";
            logMessageCol.Name = "logMessageCol";
            logMessageCol.ReadOnly = true;
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 511);
            ControlBox = false;
            Controls.Add(logEntryDataGridView);
            Controls.Add(logFormStatusStrip);
            Controls.Add(pauseLogMonitoringCheckbox);
            Controls.Add(viewFullLogsButton);
            Controls.Add(clearButton);
            Controls.Add(hideButton);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(898, 550);
            MinimumSize = new Size(898, 550);
            Name = "LogForm";
            Text = "View Logs";
            logFormStatusStrip.ResumeLayout(false);
            logFormStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logEntryDataGridView).EndInit();
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
            //Custom form start location:
            this.StartPosition = FormStartPosition.Manual;

            this.Click += LogForm_Click;

            //Clear selection when MouseDown:
            this.MouseDown += LogForm_MouseDown;

            //Customize logEntryDataGridView:
            logEntryDataGridView.MouseDown += LogEntryDataGridView_MouseDown;
            logTimestampCol.Width = 150;
            logTypeCol.Width = 60;
            logMessageCol.Width = logEntryDataGridView.Width - logTimestampCol.Width - logTypeCol.Width - 40;

            // Define cell text alignment:
            logTimestampCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            logTypeCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            logMessageCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            maxLogEntryStatusStripLabel.Text = $"Only the most recent {MAX_LOG_ROWS} log entries are shown.";

            // Initialize log file:
            //Properties.Settings.Default.LogFolder = Path.GetFullPath(".") + "\\logs";

            //logFileName = $"batch_{DateTime.Now:yyyyMMdd_HHmmss}.log";
            //logFileFullPath = Path.Combine(Properties.Settings.Default.LogFolder, logFileName);

            //if (!Directory.Exists(Properties.Settings.Default.LogFolder))
            //{
            //    Directory.CreateDirectory(Properties.Settings.Default.LogFolder);
            //}

            //File.WriteAllText(logFileFullPath, String.Empty);
        }

        #endregion

        private Button hideButton;
        private Button clearButton;
        private Button viewFullLogsButton;
        private CheckBox pauseLogMonitoringCheckbox;
        private StatusStrip logFormStatusStrip;
        private ToolStripStatusLabel maxLogEntryStatusStripLabel;
        private DataGridView logEntryDataGridView;
        private DataGridViewTextBoxColumn logTimestampCol;
        private DataGridViewTextBoxColumn logTypeCol;
        private DataGridViewTextBoxColumn logMessageCol;
    }
}