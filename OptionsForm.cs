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
    public partial class OptionsForm : Form
    {
        public OptionsForm(MainForm mainFormRef)
        {
            InitializeComponent();
            CustomInitialization();

            mainForm = mainFormRef;
        }

        private void browseOutputFolderButton_Click(object sender, EventArgs e)
        {
            if (browseOutputFolder_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputFolderTextBox.Text = browseOutputFolder_folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.OutputFolder = browseOutputFolder_folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();

                logForm.appendTextsToLog($"Output folder set to: {Properties.Settings.Default.OutputFolder}.", logForm.LOG_TYPE_INFO);
            }
            else
            {
                outputFolderTextBox.Text = Environment.CurrentDirectory;
                Properties.Settings.Default.OutputFolder = Environment.CurrentDirectory;
                Properties.Settings.Default.Save();

                logForm.appendTextsToLog($"Output folder set to: {Properties.Settings.Default.OutputFolder}.", logForm.LOG_TYPE_INFO);
            }
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputFolder = browseOutputFolder_folderBrowserDialog.SelectedPath;
            Properties.Settings.Default.EditionOrder = editionOrderComboBox.SelectedItem?.ToString();

            Properties.Settings.Default.Save();

            logForm.appendTextsToLog($"Output folder set to: {Properties.Settings.Default.OutputFolder}.", logForm.LOG_TYPE_INFO);
            logForm.appendTextsToLog($"Edition order set to: {Properties.Settings.Default.EditionOrder}", logForm.LOG_TYPE_INFO);

            this.Hide();
        }

        private void resetToDefaultButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputFolder = Environment.CurrentDirectory;
            outputFolderTextBox.Text = Properties.Settings.Default.OutputFolder;

            editionOrderComboBox.SelectedIndex = 0;
            Properties.Settings.Default.EditionOrder = editionOrderComboBox.SelectedItem?.ToString();

            Properties.Settings.Default.Save();

            logForm.appendTextsToLog($"Output folder set to: {Properties.Settings.Default.OutputFolder}.", logForm.LOG_TYPE_INFO);
            logForm.appendTextsToLog($"Edition order set to: {Properties.Settings.Default.EditionOrder}", logForm.LOG_TYPE_INFO);
        }
    }
}
