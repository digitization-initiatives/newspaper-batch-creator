using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperBatchAssemblyTool
{
    public partial class LogForm : Form
    {
        public LogForm(MainForm mainFormRef)
        {
            InitializeComponent();
            CustomInitialization();

            mainForm = mainFormRef;
        }

        #region Custom Methods

        public void appendTextsToLog(string logText, string logType)
        {
            LOG_TIMESTAMP = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            logsTextBox.AppendText(LOG_TIMESTAMP + logType + logText);
            logsTextBox.AppendText(Environment.NewLine);
            logsTextBox.ScrollToCaret();
        }

        #endregion

        private void saveLogsButton_Click(object sender, EventArgs e)
        {
            logFileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".log";
            logFileFullPath = Path.Combine(Properties.Settings.Default.OutputFolder, logFileName);
            File.WriteAllText(logFileFullPath, logsTextBox.Text);
        }

        private void clearLogsButton_Click(object sender, EventArgs e)
        {
            logsTextBox.Clear();
        }

        private void hideLogsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
