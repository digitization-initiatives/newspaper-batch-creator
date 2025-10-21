using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using NewspaperBatchCreator.src;
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
    public partial class ImportMetadataForm : Form
    {
        public ImportMetadataForm(MainForm mainFormRef)
        {
            InitializeComponent();
            CustomInitialization();

            mainForm = mainFormRef;
        }

        #region Custom Methods

        private void loadColumnMappingSampleData()
        {
            string selectedMetadataFile = selectMetadataFile_openFileDialog.FileName;

            if (selectedMetadataFile == String.Empty || selectedMetadataFile == "")
            {
                logForm.SendToLog(LogForm.LogType[LogForm.WARN], $"No metadata file selected. Please select an metadata file to continue.");
                MessageBox.Show($"No metadata file selected. Please select an metadata file to continue.", "No Metadata File Selected");
            }
            else
            {
                try
                {
                    logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"Begin loading {selectMetadataFile_openFileDialog.FileName}, please wait ... ");
                    statusText.Text = "Loading sample metadata for column mapping, please wait ... ";

                    using (var workbook = new XLWorkbook(selectMetadataFile_openFileDialog.FileName))
                    {
                        var worksheet = workbook.Worksheet(1);
                        var headerRow = worksheet.FirstRowUsed();
                        var sampleDataRow = headerRow.RowBelow();
                        int columnCount = worksheet.RangeUsed().ColumnCount();

                        for (int i = 1; i <= columnCount; i++)
                        {
                            int rowId = columnMappingDataGridView.Rows.Add();
                            columnMappingDataGridView.Rows[rowId].Cells[columnNumberCol.Index].Value = i;
                            columnMappingDataGridView.Rows[rowId].Cells[columnHeaderCol.Index].Value = headerRow.Cell(i).Value;

                            var valueCell = sampleDataRow.Cell(i);
                            columnMappingDataGridView.Rows[rowId].Cells[sampleDataCol.Index].Value = valueCell.GetFormattedString();
                        }
                    }

                    logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"Finished loading {selectMetadataFile_openFileDialog.FileName} .");
                    statusText.Text = "Sample metadata loaded.";
                }
                catch (IOException e)
                {
                    int errorCode = System.Runtime.InteropServices.Marshal.GetHRForException(e) & ((1 << 16) - 1);
                    bool isFileLocked = (errorCode == 32 || errorCode == 33);

                    if (isFileLocked)
                    {
                        logForm.SendToLog(LogForm.LogType[LogForm.ERROR], $"File {selectMetadataFile_openFileDialog.FileName} is currently in use. Please close any other applications that are using it and try again.");
                        MessageBox.Show($"File {selectMetadataFile_openFileDialog.FileName} is currently in use. Please close any other applications that are using it and try again.",
                                        "File In Use", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        selectMetadataFileTextBox.Text = String.Empty;
                        selectMetadataFile_openFileDialog.FileName = String.Empty;
                    }
                    else
                    {
                        logForm.SendToLog(LogForm.LogType[LogForm.ERROR], $"An I/O error occurred while opening file: {selectMetadataFile_openFileDialog.FileName}.");
                        MessageBox.Show("An I/O error occurred: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        selectMetadataFileTextBox.Text = String.Empty;
                        selectMetadataFile_openFileDialog.FileName = String.Empty;
                    }
                }

            }

        }

        private void saveColumnMappings()
        {
            foreach (DataGridViewRow row in columnMappingDataGridView.Rows)
            {
                string key = row.Cells[0].Value?.ToString();
                string value = row.Cells[3].Value?.ToString();

                if (key != null && value != null)
                {
                    mappedColumnsDict[key] = value;
                }
            }

            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"Column mapping completed, the mapped columns are: ");

            foreach (var dict in mappedColumnsDict)
            {
                logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"Column {dict.Key} is mapped to: {dict.Value} .");
            }
        }

        private void loadIssueMetadata()
        {
            string selectedFileName = selectMetadataFile_openFileDialog.FileName;

            if (selectedFileName == String.Empty || selectedFileName == "")
            {
                logForm.SendToLog(LogForm.LogType[LogForm.WARN], $"No metadata file selected. Please select metadata file.");
                MessageBox.Show($"No metadata file selected. Please select metadata file.", "No Metadata File Selected");
            }
            else
            {
                try
                {
                    logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"Begin loading all metadata from {selectMetadataFile_openFileDialog.FileName}, please wait ... ");

                    using (var workbook = new XLWorkbook(selectMetadataFile_openFileDialog.FileName))
                    {
                        var worksheet = workbook.Worksheet(1);
                        var headerRow = worksheet.FirstRowUsed();
                        int issueNumber;
                        int issueNumberLength = 2;

                        foreach (var row in worksheet.RowsUsed().Skip(1))
                        {
                            IssueMetadata issue = new IssueMetadata();

                            issueNumber = 1;

                            string issue_key = String.Empty;

                            foreach (var cell in row.CellsUsed())
                            {
                                int columnNumber = cell.Address.ColumnNumber;
                                string cellValue = cell.GetFormattedString();
                                mappedColumnsDict.TryGetValue(columnNumber.ToString(), out string mappedProperty);

                                switch (mappedProperty)
                                {
                                    case "ISSUE_NUMBER":
                                        issue.ISSUE_NUMBER = cellValue;
                                        break;
                                    case "TITLE":
                                        issue.TITLE = cellValue;
                                        break;
                                    case "DESCRIPTION":
                                        issue.DESCRIPTION = cellValue;
                                        break;
                                    case "DATE":
                                        issue.DATE = cellValue;
                                        break;
                                    case "VOLUME":
                                        issue.VOLUME = cellValue;
                                        break;
                                    case "FREQUENCY":
                                        issue.FREQUENCY = cellValue;
                                        break;
                                    case "NUMBER_OF_PAGES":
                                        issue.NUMBER_OF_PAGES = cellValue;
                                        break;
                                    case "DC_SUBJECT_INSTITUTION":
                                        issue.DC_SUBJECT_INSTITUTION = cellValue;
                                        break;
                                    case "DC_SUBJECT_COLLEGE":
                                        issue.DC_SUBJECT_COLLEGE = cellValue;
                                        break;
                                    case "DC_SUBJECT_LOCATION":
                                        issue.DC_SUBJECT_LOCATION = cellValue;
                                        break;
                                    case "DC_CONTRIBUTOR_COLLEGE":
                                        issue.DC_CONTRIBUTOR_COLLEGE = cellValue;
                                        break;
                                    case "DC_CONTRIBUTOR_INSTITUTION":
                                        issue.DC_CONTRIBUTOR_INSTITUTION = cellValue;
                                        break;
                                    case "DC_COVERAGE":
                                        issue.DC_COVERAGE = cellValue;
                                        break;
                                    case "DC_PUBLISHER":
                                        issue.DC_PUBLISHER = cellValue;
                                        break;
                                    case "DC_LANGUAGE":
                                        issue.DC_LANGUAGE = cellValue;
                                        break;
                                    case "DC_FORMAT":
                                        issue.DC_FORMAT = cellValue;
                                        break;
                                    case "DC_TYPE":
                                        issue.DC_TYPE = cellValue;
                                        break;
                                    case "DC_RIGHTS":
                                        issue.DC_RIGHTS = cellValue;
                                        break;
                                    default:
                                        break;
                                }
                            }

                            issue_key = issue.DATE.Replace("-", "") + Properties.Settings.Default.EditionOrder;

                            try
                            {
                                issueMetadata.Add(issue_key, issue);
                            }
                            catch (ArgumentException e)
                            {
                                logForm.SendToLog(LogForm.LogType[LogForm.ERROR], $"Duplicate metadata entry for {issue_key}, please review your metadata file to resolve the duplicates.");
                            }

                        }
                    }

                    logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"Finished loading metadata from {selectMetadataFile_openFileDialog.FileName} .");
                }
                catch (IOException e)
                {
                    int errorCode = System.Runtime.InteropServices.Marshal.GetHRForException(e) & ((1 << 16) - 1);
                    bool isFileLocked = (errorCode == 32 || errorCode == 33);

                    if (isFileLocked)
                    {
                        logForm.SendToLog(LogForm.LogType[LogForm.ERROR], $"File {selectMetadataFile_openFileDialog.FileName} is currently in use. Please close any other applications that are using it and try again.");
                        MessageBox.Show($"File {selectMetadataFile_openFileDialog.FileName} is currently in use. Please close any other applications that are using it and try again.",
                                        "File In Use", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        selectMetadataFile_openFileDialog.FileName = String.Empty;
                        //selectMetadataFileTextBox.Text = "Sanity Test";
                        MessageBox.Show("Does this not execute?");
                    }
                    else
                    {
                        logForm.SendToLog(LogForm.LogType[LogForm.ERROR], $"An I/O error occurred while opening file: {selectMetadataFile_openFileDialog.FileName}.");
                        MessageBox.Show("An I/O error occurred: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        selectMetadataFile_openFileDialog.FileName = String.Empty;
                        selectMetadataFileTextBox.Text = String.Empty;
                    }
                }
            }

            foreach (var item in issueMetadata)
            {
                logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"{item.Key} - " +
                    $"{item.Value.ISSUE_NUMBER}, " +
                    $"{item.Value.TITLE}, " +
                    $"{item.Value.DESCRIPTION}, " +
                    $"{item.Value.DATE}, " +
                    $"{item.Value.VOLUME}, " +
                    $"{item.Value.FREQUENCY}, " +
                    $"{item.Value.NUMBER_OF_PAGES}, " +
                    $"{item.Value.DC_SUBJECT_INSTITUTION}, " +
                    $"{item.Value.DC_SUBJECT_COLLEGE}, " +
                    $"{item.Value.DC_SUBJECT_LOCATION}, " +
                    $"{item.Value.DC_CONTRIBUTOR_COLLEGE}, " +
                    $"{item.Value.DC_CONTRIBUTOR_INSTITUTION}, " +
                    $"{item.Value.DC_COVERAGE}, " +
                    $"{item.Value.DC_PUBLISHER}, " +
                    $"{item.Value.DC_LANGUAGE}, " +
                    $"{item.Value.DC_FORMAT}, " +
                    $"{item.Value.DC_TYPE}, " +
                    $"{item.Value.DC_RIGHTS}");
            }

            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"{issueMetadata.Count} metadata entries have been loaded.");

        }

        #endregion

        private void importAndCloseButton_Click(object sender, EventArgs e)
        {
            saveColumnMappings();
            loadIssueMetadata();

            Properties.Settings.Default.MetadataLoaded = true;
            Properties.Settings.Default.Save();

            mainForm.statusBar_MetadataLoaded.Text = $"Metadata loaded.";

            //Enable load source files function:
            mainForm.selectFolderButton.Enabled = true;

            this.Hide();
        }

        private void selectMetadataFileButton_Click(object sender, EventArgs e)
        {
            if (selectMetadataFile_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectMetadataFileTextBox.Text = selectMetadataFile_openFileDialog.FileName;
                loadColumnMappingSampleData();
            }
            else
            {
                selectMetadataFileTextBox.Text = String.Empty;
            }
        }

        private void startOverButton_Click(object sender, EventArgs e)
        {
            columnMappingDataGridView.Rows.Clear();
            selectMetadataFileTextBox.Text = String.Empty;
            selectMetadataFile_openFileDialog.FileName = String.Empty;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
