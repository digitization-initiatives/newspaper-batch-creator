using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using NewspaperBatchAssemblyTool.src;
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
            if (selectMetadataFile_openFileDialog.FileName != null)
            {
                try
                {
                    logForm.appendTextsToLog($"Begin loading {selectMetadataFile_openFileDialog.FileName}, please wait ... ", logForm.LOG_TYPE_INFO);

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

                    logForm.appendTextsToLog($"Finished loading {selectMetadataFile_openFileDialog.FileName} .", logForm.LOG_TYPE_INFO);
                }
                catch (IOException e)
                {
                    int errorCode = System.Runtime.InteropServices.Marshal.GetHRForException(e) & ((1 << 16) - 1);
                    bool isFileLocked = (errorCode == 32 || errorCode == 33);

                    if (isFileLocked)
                    {
                        logForm.appendTextsToLog($"File {selectMetadataFile_openFileDialog.FileName} is currently in use. Please close any other applications that are using it and try again.", logForm.LOG_TYPE_ERROR);

                        MessageBox.Show($"File {selectMetadataFile_openFileDialog.FileName} is currently in use. Please close any other applications that are using it and try again.",
                                        "File In Use", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        logForm.appendTextsToLog($"An I/O error occurred while opening file: {selectMetadataFile_openFileDialog.FileName}.", logForm.LOG_TYPE_ERROR);

                        MessageBox.Show("An I/O error occurred: " + e.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            logForm.appendTextsToLog($"Column mapping completed, the mapped columns are: ", logForm.LOG_TYPE_INFO);

            foreach (var dict in mappedColumnsDict)
            {
                logForm.appendTextsToLog($"Column {dict.Key} is mapped to: {dict.Value} .", logForm.LOG_TYPE_INFO);
            }
        }

        private void loadIssueMetadata()
        {
            if (selectMetadataFile_openFileDialog.FileName != null)
            {
                try
                {
                    logForm.appendTextsToLog($"Begin loading all metadata from {selectMetadataFile_openFileDialog.FileName}, please wait ... ", logForm.LOG_TYPE_INFO);

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

                            issue_key = issue.DATE.Replace("-", "") + issueNumber.ToString("D" + issueNumberLength);

                            while (issueMetadata.ContainsKey(issue_key))
                            {
                                issueNumber += 1;
                                issue_key = issue.DATE.Replace("-", "") + issueNumber.ToString("D" + issueNumberLength);
                            }

                            try
                            {
                                issueMetadata.Add(issue_key, issue);
                            }
                            catch (ArgumentException e)
                            {
                                logForm.appendTextsToLog($"Duplicate metadata entry for {issue_key}, please review your metadata file to resolve the duplicates.", logForm.LOG_TYPE_ERROR);
                            }

                        }
                    }

                    logForm.appendTextsToLog($"Finished loading metadata from {selectMetadataFile_openFileDialog.FileName} .", logForm.LOG_TYPE_INFO);
                }
                catch (IOException e)
                {
                    int errorCode = System.Runtime.InteropServices.Marshal.GetHRForException(e) & ((1 << 16) - 1);
                    bool isFileLocked = (errorCode == 32 || errorCode == 33);

                    if (isFileLocked)
                    {
                        logForm.appendTextsToLog($"File {selectMetadataFile_openFileDialog.FileName} is currently in use. Please close any other applications that are using it and try again.", logForm.LOG_TYPE_ERROR);

                        MessageBox.Show($"File {selectMetadataFile_openFileDialog.FileName} is currently in use. Please close any other applications that are using it and try again.",
                                        "File In Use", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        logForm.appendTextsToLog($"An I/O error occurred while opening file: {selectMetadataFile_openFileDialog.FileName}.", logForm.LOG_TYPE_ERROR);

                        MessageBox.Show("An I/O error occurred: " + e.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            foreach (var item in issueMetadata)
            {
                logForm.appendTextsToLog($"{item.Key} - " +
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
                    $"{item.Value.DC_RIGHTS}", logForm.LOG_TYPE_INFO);
            }
        }

        #endregion

        private void exitButton_Click(object sender, EventArgs e)
        {
            saveColumnMappings();
            loadIssueMetadata();

            Properties.Settings.Default.MetadataLoaded = true;
            Properties.Settings.Default.Save();

            mainForm.statusBarMetadataFileLoadedLabel.Text = $"Metadata loaded.";

            //Enable Assemble Batch button:
            if (Properties.Settings.Default.SourceFilesLoaded && Properties.Settings.Default.MetadataLoaded)
            {
                mainForm.assembleBatchButton.Enabled = true;
            }

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
            selectMetadataFileTextBox.Text= String.Empty;
            selectMetadataFile_openFileDialog.FileName = String.Empty;
        }
    }
}
