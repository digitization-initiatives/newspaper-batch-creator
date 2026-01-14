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
    public partial class ImportEditMetadataForm : Form
    {
        public ImportEditMetadataForm(MainForm mainFormRef, LogForm logFormRef)
        {
            mainForm = mainFormRef;
            logForm = logFormRef;

            InitializeComponent();
            CustomInitialization();
        }

        #region Custom Methods

        //private void loadIssueMetadata()
        //{
        //    string selectedFileName = importViaCSV_openFileDialog.FileName;

        //    if (selectedFileName == String.Empty || selectedFileName == "")
        //    {
        //        logForm.SendToLog(LogForm.LogType.WARN, $"No metadata file selected. Please select metadata file.");
        //        MessageBox.Show($"No metadata file selected. Please select metadata file.", "No Metadata File Selected");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            logForm.SendToLog(LogForm.LogType.INFO, $"Begin loading all metadata from {importViaCSV_openFileDialog.FileName}, please wait ... ");

        //            using (var workbook = new XLWorkbook(importViaCSV_openFileDialog.FileName))
        //            {
        //                var worksheet = workbook.Worksheet(1);
        //                var headerRow = worksheet.FirstRowUsed();
        //                int issueNumber;
        //                int issueNumberLength = 2;

        //                foreach (var row in worksheet.RowsUsed().Skip(1))
        //                {
        //                    IssueMetadata issue = new IssueMetadata();

        //                    issueNumber = 1;

        //                    string issue_key = String.Empty;

        //                    foreach (var cell in row.CellsUsed())
        //                    {
        //                        int columnNumber = cell.Address.ColumnNumber;
        //                        string cellValue = cell.GetFormattedString();
        //                        mappedColumnsDict.TryGetValue(columnNumber.ToString(), out string mappedProperty);

        //                        switch (mappedProperty)
        //                        {
        //                            case "ISSUE_NUMBER":
        //                                issue.ISSUE_NUMBER = cellValue;
        //                                break;
        //                            case "TITLE":
        //                                issue.TITLE = cellValue;
        //                                break;
        //                            case "DESCRIPTION":
        //                                issue.DESCRIPTION = cellValue;
        //                                break;
        //                            case "DATE":
        //                                issue.DATE = cellValue;
        //                                break;
        //                            case "VOLUME":
        //                                issue.VOLUME = cellValue;
        //                                break;
        //                            case "FREQUENCY":
        //                                issue.FREQUENCY = cellValue;
        //                                break;
        //                            case "NUMBER_OF_PAGES":
        //                                issue.NUMBER_OF_PAGES = cellValue;
        //                                break;
        //                            case "DC_SUBJECT_INSTITUTION":
        //                                issue.DC_SUBJECT_INSTITUTION = cellValue;
        //                                break;
        //                            case "DC_SUBJECT_COLLEGE":
        //                                issue.DC_SUBJECT_COLLEGE = cellValue;
        //                                break;
        //                            case "DC_SUBJECT_LOCATION":
        //                                issue.DC_SUBJECT_LOCATION = cellValue;
        //                                break;
        //                            case "DC_CONTRIBUTOR_COLLEGE":
        //                                issue.DC_CONTRIBUTOR_COLLEGE = cellValue;
        //                                break;
        //                            case "DC_CONTRIBUTOR_INSTITUTION":
        //                                issue.DC_CONTRIBUTOR_INSTITUTION = cellValue;
        //                                break;
        //                            case "DC_COVERAGE":
        //                                issue.DC_COVERAGE = cellValue;
        //                                break;
        //                            case "DC_PUBLISHER":
        //                                issue.DC_PUBLISHER = cellValue;
        //                                break;
        //                            case "DC_LANGUAGE":
        //                                issue.DC_LANGUAGE = cellValue;
        //                                break;
        //                            case "DC_FORMAT":
        //                                issue.DC_FORMAT = cellValue;
        //                                break;
        //                            case "DC_TYPE":
        //                                issue.DC_TYPE = cellValue;
        //                                break;
        //                            case "DC_RIGHTS":
        //                                issue.DC_RIGHTS = cellValue;
        //                                break;
        //                            default:
        //                                break;
        //                        }
        //                    }

        //                    issue_key = issue.DATE.Replace("-", "") + Properties.Settings.Default.EditionOrder;

        //                    try
        //                    {
        //                        issueMetadata.Add(issue_key, issue);
        //                    }
        //                    catch (ArgumentException e)
        //                    {
        //                        logForm.SendToLog(LogForm.LogType.ERROR, $"Duplicate metadata entry for {issue_key}, please review your metadata file to resolve the duplicates.");
        //                    }

        //                }
        //            }

        //            logForm.SendToLog(LogForm.LogType.INFO, $"Finished loading metadata from {importViaCSV_openFileDialog.FileName} .");
        //        }
        //        catch (IOException e)
        //        {
        //            int errorCode = System.Runtime.InteropServices.Marshal.GetHRForException(e) & ((1 << 16) - 1);
        //            bool isFileLocked = (errorCode == 32 || errorCode == 33);

        //            if (isFileLocked)
        //            {
        //                logForm.SendToLog(LogForm.LogType.ERROR, $"File {importViaCSV_openFileDialog.FileName} is currently in use. Please close any other applications that are using it and try again.");
        //                MessageBox.Show($"File {importViaCSV_openFileDialog.FileName} is currently in use. Please close any other applications that are using it and try again.",
        //                                "File In Use", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //                importViaCSV_openFileDialog.FileName = String.Empty;
        //                //selectMetadataFileTextBox.Text = "Sanity Test";
        //                MessageBox.Show("Does this not execute?");
        //            }
        //            else
        //            {
        //                logForm.SendToLog(LogForm.LogType.ERROR, $"An I/O error occurred while opening file: {importViaCSV_openFileDialog.FileName}.");
        //                MessageBox.Show("An I/O error occurred: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //                importViaCSV_openFileDialog.FileName = String.Empty;
        //                selectMetadataFileTextBox.Text = String.Empty;
        //            }
        //        }
        //    }

        //    foreach (var item in issueMetadata)
        //    {
        //        logForm.SendToLog(LogForm.LogType.INFO, $"{item.Key} - " +
        //            $"{item.Value.ISSUE_NUMBER}, " +
        //            $"{item.Value.TITLE}, " +
        //            $"{item.Value.DESCRIPTION}, " +
        //            $"{item.Value.DATE}, " +
        //            $"{item.Value.VOLUME}, " +
        //            $"{item.Value.FREQUENCY}, " +
        //            $"{item.Value.NUMBER_OF_PAGES}, " +
        //            $"{item.Value.DC_SUBJECT_INSTITUTION}, " +
        //            $"{item.Value.DC_SUBJECT_COLLEGE}, " +
        //            $"{item.Value.DC_SUBJECT_LOCATION}, " +
        //            $"{item.Value.DC_CONTRIBUTOR_COLLEGE}, " +
        //            $"{item.Value.DC_CONTRIBUTOR_INSTITUTION}, " +
        //            $"{item.Value.DC_COVERAGE}, " +
        //            $"{item.Value.DC_PUBLISHER}, " +
        //            $"{item.Value.DC_LANGUAGE}, " +
        //            $"{item.Value.DC_FORMAT}, " +
        //            $"{item.Value.DC_TYPE}, " +
        //            $"{item.Value.DC_RIGHTS}");
        //    }

        //    logForm.SendToLog(LogForm.LogType.INFO, $"{issueMetadata.Count} metadata entries have been loaded.");

        //}

        #endregion

        private void importViaCSVButton_Click(object sender, EventArgs e)
        {
            if (importViaCSV_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                metadataCsvFilePath = importViaCSV_openFileDialog.FileName;
                metadataCsvFilePathStatus.Text = metadataCsvFilePath;

                utilities.ImportMetadataViaCSV(viewOrEditMetadataDataGridView, metadataCsvFilePath);

                int numberOfItemsAddedCount = viewOrEditMetadataDataGridView.Rows.Cast<DataGridViewRow>().Count(row => !row.IsNewRow);
                numberOfItemsAdded.Text = numberOfItemsAddedCount.ToString();
            }
            else
            {
                metadataCsvFilePath = String.Empty;
                importViaCSV_openFileDialog.FileName = String.Empty;
                logForm.Logger(LogForm.LogType.WARN, $"No metadata CSV file selected.");
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            importViaCSV_openFileDialog.FileName = String.Empty;
            viewOrEditMetadataDataGridView.Rows.Clear();

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            utilities.UpdateMetadata_Items(viewOrEditMetadataDataGridView);
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            utilities.UpdateMetadata_Items(viewOrEditMetadataDataGridView);
            this.Hide();
        }
        private void ImportEditMetadataForm_MouseDown(object sender, MouseEventArgs e)
        {
            viewOrEditMetadataDataGridView.ClearSelection();
        }

        private void viewOrEditMetadataDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo clickLocation = viewOrEditMetadataDataGridView.HitTest(e.X, e.Y);

            if (clickLocation.Type == DataGridViewHitTestType.None)
            {
                viewOrEditMetadataDataGridView.ClearSelection();
            }
        }

        private void viewOrEditMetadataDataGridView_RowsChanged(object sender, EventArgs e)
        {
            int numberOfItemsAddedCount = viewOrEditMetadataDataGridView.Rows.Cast<DataGridViewRow>().Count(row => !row.IsNewRow);
            numberOfItemsAdded.Text = numberOfItemsAddedCount.ToString();
        }

        private void viewOrEditMetadataDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (viewOrEditMetadataDataGridView.IsCurrentCellDirty)
            {
                viewOrEditMetadataDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}

