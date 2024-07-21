using NewspaperBatchAssemblyTool.src;
using System.Collections.Specialized;

namespace NewspaperBatchAssemblyTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomInitialization();
        }

        #region Custom Methods
        private void loadLccnComboBoxItems()
        {
            foreach (var lccn in LCCN.LCCN_ITEMS)
            {
                lccnComboBox.Items.Add($"{lccn.Key} - {lccn.Value.TITLE}");
            }
        }

        private void lccnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lccnComboBox.SelectedIndex != -1)
            {
                string selectedLccn = lccnComboBox.SelectedItem.ToString().Substring(0, 10);
                LCCN_PROPERTIES lccnProperties;
                LCCN.LCCN_ITEMS.TryGetValue(selectedLccn, out lccnProperties);
                batchNamePrefixTextBox.Text = lccnProperties.BATCH_PREFIX;
            }
        }

        private bool validateBatchNumberTextBoxInput()
        {
            return true;
        }

        #endregion Custom Methods

        private void browseSourceFilesButton_Click(object sender, EventArgs e)
        {
            if (browseSourceFiles_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                sourceFilesPathTextBox.Text = browseSourceFiles_folderBrowserDialog.SelectedPath;
                loadSourceFilesButton.Enabled = true;
            }
            else
            {
                sourceFilesPathTextBox.Text = String.Empty;
            }
        }

        private void loadSourceFilesButton_Click(object sender, EventArgs e)
        {
            if (browseSourceFiles_folderBrowserDialog.SelectedPath != null)
            {
                List<string> files = new List<string>();
                files.AddRange(Directory.GetFiles(browseSourceFiles_folderBrowserDialog.SelectedPath, "*.*", SearchOption.AllDirectories));

                foreach (string file in files)
                {
                    ListViewItem item = new ListViewItem(file);
                    item.SubItems.Add(STATUS_LOADED);

                    sourceFilesListView.Items.Add(item);
                }

                statusBarNumberOfSourceFilesLabel.Text = $"{sourceFilesListView.Items.Count} files loaded.";
            }
        }

        private void loadMetadataFileButton_Click(object sender, EventArgs e)
        {
            
        }

        private void setBatchNumberButton_Click(object sender, EventArgs e)
        {


            if (batchNumberTextBox.Enabled)
            {
                setBatchNumberButton.Text = "Unset";
                batchNumberTextBox.Enabled = false;
            }
            else
            {
                setBatchNumberButton.Text = "Set";
                batchNumberTextBox.Enabled = true;
            }
        }

        private void assembleBatchButton_Click(object sender, EventArgs e)
        {

        }

        private void startOverButton_Click(object sender, EventArgs e)
        {

        }

        private void viewLogsButton_Click(object sender, EventArgs e)
        {
            logForm.Show();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importMetadataButton_Click(object sender, EventArgs e)
        {
            importMetadataForm.Show();
        }
    }
}
