using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperBatchCreation
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(MainForm mainFormRef)
        {
            InitializeComponent();
            CustomInitialization();

            mainForm = mainFormRef;
        }

        private void browseOutputFolderButton_Click(object sender, EventArgs e)
        {
            if (selectOutputFolder_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputFolderTextBox.Text = selectOutputFolder_folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.OutputFolder = selectOutputFolder_folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();

                logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"Output folder set to: {Properties.Settings.Default.OutputFolder}.");
            }
            else
            {
                outputFolderTextBox.Text = Environment.CurrentDirectory;
                Properties.Settings.Default.OutputFolder = Environment.CurrentDirectory;
                Properties.Settings.Default.Save();

                logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"Output folder set to: {Properties.Settings.Default.OutputFolder}.");
            }
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputFolder = selectOutputFolder_folderBrowserDialog.SelectedPath;
            Properties.Settings.Default.EditionOrder = editionOrderComboBox.SelectedItem?.ToString();

            Properties.Settings.Default.Save();

            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"Output folder set to: {Properties.Settings.Default.OutputFolder}.");
            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"Edition order set to: {Properties.Settings.Default.EditionOrder}");

            this.Hide();
        }

        private void resetToDefaultButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputFolder = Environment.CurrentDirectory;
            outputFolderTextBox.Text = Properties.Settings.Default.OutputFolder;

            editionOrderComboBox.SelectedIndex = 0;
            Properties.Settings.Default.EditionOrder = editionOrderComboBox.SelectedItem?.ToString();

            Properties.Settings.Default.Save();

            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"Output folder set to: {Properties.Settings.Default.OutputFolder}.");
            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"Edition order set to: {Properties.Settings.Default.EditionOrder}");
        }
    }
}
