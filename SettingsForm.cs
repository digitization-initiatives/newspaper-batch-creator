using NewspaperBatchCreator.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperBatchCreator
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(MainForm mainFormRef, LogForm logFormRef)
        {
            mainForm = mainFormRef;
            logForm = logFormRef;

            InitializeComponent();
            CustomInitialization();
        }

        private void browseOutputFolderButton_Click(object sender, EventArgs e)
        {
            //if (selectOutputFolder_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            //{
            //outputFolderTextBox.Text = selectOutputFolder_folderBrowserDialog.SelectedPath;
            //Properties.Settings.Default.SourceFolder = selectOutputFolder_folderBrowserDialog.SelectedPath;
            //Properties.Settings.Default.Save();

            //logForm.SendToLog(LogForm.LogType.INFO, $"Output folder set to: {Properties.Settings.Default.SourceFolder}.");
            //}
            //else
            //{
            //outputFolderTextBox.Text = Environment.CurrentDirectory;
            //Properties.Settings.Default.SourceFolder = Environment.CurrentDirectory;
            //Properties.Settings.Default.Save();

            //logForm.SendToLog(LogForm.LogType.INFO, $"Output folder set to: {Properties.Settings.Default.SourceFolder}.");
            //}
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.SourceFolder = selectOutputFolder_folderBrowserDialog.SelectedPath;

            Properties.Settings.Default.Save();

            //logForm.SendToLog(LogForm.LogType.INFO, $"Output folder set to: {Properties.Settings.Default.SourceFolder}.");
            //logForm.SendToLog(LogForm.LogType.INFO, $"Edition order set to: {Properties.Settings.Default.EditionOrder}");

            this.Hide();
        }

        private void resetToDefaultButton_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.SourceFolder = Environment.CurrentDirectory;
            //outputFolderTextBox.Text = Properties.Settings.Default.OutputFolder;

            Properties.Settings.Default.Save();

            //logForm.SendToLog(LogForm.LogType.INFO, $"Output folder set to: {Properties.Settings.Default.SourceFolder}.");
            //logForm.SendToLog(LogForm.LogType.INFO, $"Edition order set to: {Properties.Settings.Default.EditionOrder}");
        }

        private void batchNamePrefixTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            
        }

        private void organizationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (organizationsListBox.SelectedItem is JsonFileItem jsonFileItem)
            {
                try
                {
                    string jsonFile = File.ReadAllText(jsonFileItem.FILE_PATH);
                    Organizations organization = JsonSerializer.Deserialize<Organizations>(jsonFile);

                    organizationsPropertyGrid.SelectedObject = organization;

                    logForm.Logger(LogForm.LogType.INFO, $"Organization \"{jsonFileItem.ToString()}\" loaded.");
                }
                catch (Exception ex)
                {
                    logForm.Logger(LogForm.LogType.ERROR, $"Failed to load settings from {jsonFileItem.ToString()}: {ex.Message}");
                }
            }
        }
    }
}
