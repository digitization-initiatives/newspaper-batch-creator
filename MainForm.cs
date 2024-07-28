using DocumentFormat.OpenXml.Wordprocessing;
using NewspaperBatchAssemblyTool.src;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

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
                selectLccnComboBox.Items.Add($"{lccn.Key} - {lccn.Value.TITLE}");
            }
        }

        private void lccnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectLccnComboBox.SelectedIndex != -1)
            {
                Properties.Settings.Default.SeletedLccn = selectLccnComboBox.SelectedItem.ToString().Substring(0, 10);
                Properties.Settings.Default.Save();

                //Automatically populate the BATCH_PREFIX based on selected LCCN:
                LCCN_PROPERTIES lccnProperties;
                LCCN.LCCN_ITEMS.TryGetValue(Properties.Settings.Default.SeletedLccn, out lccnProperties);
                batchNamePrefixTextBox.Text = lccnProperties.BATCH_PREFIX;

                //Set award year based on selected LCCN:
                switch (Properties.Settings.Default.SeletedLccn)
                {
                    case "sn37020267":
                        Properties.Settings.Default.AwardYear = "2020";
                        Properties.Settings.Default.Save();
                        logForm.appendTextsToLog($"AwardYear for \"{selectLccnComboBox.SelectedItem}\" is set to {Properties.Settings.Default.AwardYear}.", logForm.LOG_TYPE_INFO);
                        break;
                    case "sn86088544":
                        Properties.Settings.Default.AwardYear = "2015";
                        Properties.Settings.Default.Save();
                        logForm.appendTextsToLog($"AwardYear for \"{selectLccnComboBox.SelectedItem}\" is set to {Properties.Settings.Default.AwardYear}.", logForm.LOG_TYPE_INFO);
                        break;
                    case "sn88037063":
                        Properties.Settings.Default.AwardYear = "2020";
                        Properties.Settings.Default.Save();
                        logForm.appendTextsToLog($"AwardYear for \"{selectLccnComboBox.SelectedItem}\" is set to {Properties.Settings.Default.AwardYear}.", logForm.LOG_TYPE_INFO);
                        break;
                    default:
                        Properties.Settings.Default.AwardYear = String.Empty;
                        Properties.Settings.Default.Save();
                        logForm.appendTextsToLog($"No newspaper is selected. AwardYear is set to String.Empty.", logForm.LOG_TYPE_INFO);
                        break;
                }

            }
        }

        private bool validate_batchNumberTextBox()
        {
            return Regex.IsMatch(batchNumberTextBox.Text, @"^\d+$");
        }

        private void constructDestinationFileStructure()
        {
            foreach (ListViewItem sourceFileItem in sourceFilesListView.Items)
            {

                DestinationFilesStructure destItem = new DestinationFilesStructure();

                destItem.SOURCE_FILE_PATH = sourceFileItem.SubItems[0].Text;
                destItem.OUTPUT_FOLDER_PATH = Properties.Settings.Default.OutputFolder;
                destItem.BATCH_FOLDER_NAME = batchNamePrefixTextBox.Text + batchNumberTextBox.Text;
                destItem.DATA_FOLDER_NAME = "data";

                destItem.BATCH_XML_FILE_PATH = Path.Combine(destItem.OUTPUT_FOLDER_PATH, destItem.BATCH_FOLDER_NAME, destItem.DATA_FOLDER_NAME, "batch.xml");

                destItem.LCCN_FOLDER_NAME = Properties.Settings.Default.SeletedLccn;
                destItem.PRINT_FOLDER_NAME = "print";

                string sourceFileIssueFolderName = Directory.GetParent(destItem.SOURCE_FILE_PATH).Name;
                destItem.ISSUE_FOLDER_NAME = sourceFileIssueFolderName.Substring(sourceFileIssueFolderName.Length - 10).Replace("-", "") + Properties.Settings.Default.EditionOrder;

                destItem.DESTINATION_FILE_PATH = Path.Combine(
                    destItem.OUTPUT_FOLDER_PATH, destItem.BATCH_FOLDER_NAME, destItem.DATA_FOLDER_NAME,
                    destItem.LCCN_FOLDER_NAME, destItem.PRINT_FOLDER_NAME,
                    destItem.ISSUE_FOLDER_NAME, Path.GetFileName(destItem.SOURCE_FILE_PATH)
                    );

                destItem.ISSUE_XML_FILE_PATH = Path.Combine(
                    destItem.OUTPUT_FOLDER_PATH, destItem.BATCH_FOLDER_NAME, destItem.DATA_FOLDER_NAME,
                    destItem.LCCN_FOLDER_NAME, destItem.PRINT_FOLDER_NAME,
                    destItem.ISSUE_FOLDER_NAME, destItem.ISSUE_FOLDER_NAME + ".xml"
                    );

                destinationFileStructure.Add( destItem );
            }

            //foreach ( DestinationFilesStructure item in destinationFileStructure )
            //{
            //    logForm.appendTextsToLog(item.SOURCE_FILE_PATH, logForm.LOG_TYPE_INFO);
            //    logForm.appendTextsToLog(item.DESTINATION_FILE_PATH, logForm.LOG_TYPE_INFO);
            //}

        }

        private void assembleBatch_CopyFiles()
        {
            foreach (DestinationFilesStructure batchItem in destinationFileStructure)
            {
                try
                {
                    string destinationDirectory = Path.GetDirectoryName(batchItem.DESTINATION_FILE_PATH);
                    if (!Directory.Exists(destinationDirectory))
                    {
                        Directory.CreateDirectory(destinationDirectory);
                        logForm.appendTextsToLog($"{destinationDirectory} doesn't existed, but has been created.", logForm.LOG_TYPE_INFO);
                    }

                    File.Copy(batchItem.SOURCE_FILE_PATH, batchItem.DESTINATION_FILE_PATH, overwrite: true);
                    logForm.appendTextsToLog($"File: \"{batchItem.DESTINATION_FILE_PATH}\" has been added to \"{batchItem.BATCH_FOLDER_NAME}\".", logForm.LOG_TYPE_INFO);
                }
                catch (IOException ex)
                {
                    logForm.appendTextsToLog($"An error occurred: {ex.Message}", logForm.LOG_TYPE_ERROR);
                }
            }
        }

        #endregion Custom Methods

        private void browseSourceFilesButton_Click(object sender, EventArgs e)
        {
            if (browseSourceFiles_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                sourceFilesPathTextBox.Text = browseSourceFiles_folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.SourceFolder = browseSourceFiles_folderBrowserDialog.SelectedPath;

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

                //Enable Assemble Batch button:
                assembleBatchButton.Enabled = true;
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
            if (selectLccnComboBox.SelectedIndex == -1)
            {
                logForm.appendTextsToLog($"No LCCN/Newspaper Selected. Please select a newspaper.", logForm.LOG_TYPE_ERROR);
                MessageBox.Show($"No LCCN/Newspaper has been selected. Please select a newspaper.", $"No LCCN/Newspaper Selected");
            }
            else if (!validate_batchNumberTextBox())
            {
                logForm.appendTextsToLog($"Invalid Batch Number. No batch number provided or batch number contains invalid characters!", logForm.LOG_TYPE_ERROR);
                MessageBox.Show($"No batch number provided or batch number contains invalid characters!", $"Invalid Batch Number");
            }
            else
            {
                constructDestinationFileStructure();
                logForm.appendTextsToLog($"Destination file structure has been constructed.", logForm.LOG_TYPE_INFO);

                assembleBatch_CopyFiles();
                logForm.appendTextsToLog($"Batch files have been copied.", logForm.LOG_TYPE_INFO);
            }
        }

        private void startOverButton_Click(object sender, EventArgs e)
        {

        }

        private void viewLogsButton_Click(object sender, EventArgs e)
        {
            if (logForm.Visible)
            {
                logForm.BringToFront();
            }
            else
            {
                logForm.Location = new Point(this.Location.X + this.Width + 10, this.Location.Y);
                logForm.Show();
            }
            
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            if (optionsForm.Visible)
            {
                optionsForm.BringToFront();
            }
            else
            {
                optionsForm.Location = new Point(this.Location.X + this.Width + 10, this.Location.Y);
                optionsForm.Show();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importMetadataButton_Click(object sender, EventArgs e)
        {
            importMetadataForm.Show();
        }

        private void browseOutputFolderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
