namespace NewspaperBatchAssemblyTool
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
            logsTextBox = new TextBox();
            hideLogsButton = new Button();
            clearLogsButton = new Button();
            saveLogsButton = new Button();
            SuspendLayout();
            // 
            // logsTextBox
            // 
            logsTextBox.BackColor = Color.FromArgb(64, 64, 64);
            logsTextBox.ForeColor = Color.Green;
            logsTextBox.Location = new Point(12, 12);
            logsTextBox.Multiline = true;
            logsTextBox.Name = "logsTextBox";
            logsTextBox.ScrollBars = ScrollBars.Vertical;
            logsTextBox.Size = new Size(758, 794);
            logsTextBox.TabIndex = 0;
            // 
            // hideLogsButton
            // 
            hideLogsButton.Location = new Point(650, 812);
            hideLogsButton.Name = "hideLogsButton";
            hideLogsButton.Size = new Size(120, 29);
            hideLogsButton.TabIndex = 1;
            hideLogsButton.Text = "Hide Logs";
            hideLogsButton.UseVisualStyleBackColor = true;
            hideLogsButton.Click += hideLogsButton_Click;
            // 
            // clearLogsButton
            // 
            clearLogsButton.Location = new Point(524, 812);
            clearLogsButton.Name = "clearLogsButton";
            clearLogsButton.Size = new Size(120, 29);
            clearLogsButton.TabIndex = 2;
            clearLogsButton.Text = "Clear Logs";
            clearLogsButton.UseVisualStyleBackColor = true;
            clearLogsButton.Click += clearLogsButton_Click;
            // 
            // saveLogsButton
            // 
            saveLogsButton.Location = new Point(398, 812);
            saveLogsButton.Name = "saveLogsButton";
            saveLogsButton.Size = new Size(120, 29);
            saveLogsButton.TabIndex = 3;
            saveLogsButton.Text = "Save Logs";
            saveLogsButton.UseVisualStyleBackColor = true;
            saveLogsButton.Click += saveLogsButton_Click;
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 853);
            Controls.Add(saveLogsButton);
            Controls.Add(clearLogsButton);
            Controls.Add(hideLogsButton);
            Controls.Add(logsTextBox);
            MinimumSize = new Size(800, 900);
            Name = "LogForm";
            Text = "LogForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Initialization

        private MainForm mainForm;

        public string LOG_TYPE_INFO, LOG_TYPE_WARN, LOG_TYPE_ERROR;
        private string LOG_TIMESTAMP;

        private void CustomInitialization()
        {
            //Custom form start location:
            this.StartPosition = FormStartPosition.Manual;

            //Initialize log types and timestamp:
            LOG_TYPE_INFO = " - [INFO] - ";
            LOG_TYPE_WARN = " - [WARN] - ";
            LOG_TYPE_ERROR = " - [ERROR] - ";

            LOG_TIMESTAMP = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        #endregion

        private TextBox logsTextBox;
        private Button hideLogsButton;
        private Button clearLogsButton;
        private Button saveLogsButton;
    }
}