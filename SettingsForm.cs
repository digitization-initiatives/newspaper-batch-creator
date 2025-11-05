using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperBatchCreator
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(MainForm mainFormRef)
        {
            InitializeComponent();
            CustomInitialization();

            mainForm = mainFormRef;
        }

        private void settingsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (settingsTabControl.SelectedTab == applicationAndBatchSettingsTab)
            {
                selectLccnComboBox.Visible = false;
            }
            else
            {
                selectLccnComboBox.Visible = true;
            }
        }

        private void browseOutputFolderButton_Click(object sender, EventArgs e)
        {
            if (selectOutputFolder_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //outputFolderTextBox.Text = selectOutputFolder_folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.OutputFolder = selectOutputFolder_folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();

                logForm.SendToLog(LogForm.LogType.INFO, $"Output folder set to: {Properties.Settings.Default.OutputFolder}.");
            }
            else
            {
                //outputFolderTextBox.Text = Environment.CurrentDirectory;
                Properties.Settings.Default.OutputFolder = Environment.CurrentDirectory;
                Properties.Settings.Default.Save();

                logForm.SendToLog(LogForm.LogType.INFO, $"Output folder set to: {Properties.Settings.Default.OutputFolder}.");
            }
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputFolder = selectOutputFolder_folderBrowserDialog.SelectedPath;

            Properties.Settings.Default.Save();

            logForm.SendToLog(LogForm.LogType.INFO, $"Output folder set to: {Properties.Settings.Default.OutputFolder}.");
            logForm.SendToLog(LogForm.LogType.INFO, $"Edition order set to: {Properties.Settings.Default.EditionOrder}");

            this.Hide();
        }

        private void resetToDefaultButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputFolder = Environment.CurrentDirectory;
            //outputFolderTextBox.Text = Properties.Settings.Default.OutputFolder;

            Properties.Settings.Default.Save();

            logForm.SendToLog(LogForm.LogType.INFO, $"Output folder set to: {Properties.Settings.Default.OutputFolder}.");
            logForm.SendToLog(LogForm.LogType.INFO, $"Edition order set to: {Properties.Settings.Default.EditionOrder}");
        }

        private void batchNamePrefixTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
