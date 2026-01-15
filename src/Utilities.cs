using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace NewspaperBatchCreator.src
{
    internal class Utilities
    {
        private MainForm mainForm;
        private LogForm logForm;

        internal Utilities(MainForm _mainForm, LogForm _logForm)
        {
            mainForm = _mainForm;
            logForm = _logForm;
        }

        // Export Metadata Template:
        public void ExportMetadataTemplate(string filePath)
        {
            List<string> csv = new List<string>();
            csv.Add("item,date,volume,issue,edition,pages");
            csv.Add("newspapertitle_1900-01-01,1900-01-01,1,1,01,1");

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
                {
                    // Testing if file is open by another process.
                }

                File.WriteAllLines(filePath, csv);
                logForm.Logger(LogForm.LogType.INFO, $"Metadata Template exported to {filePath}.");
            }
            catch (IOException)
            {
                MessageBox.Show($"{filePath} is being used by another process. Metadata Template is not exported.", "File In Use", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                logForm.Logger(LogForm.LogType.WARN, $"{filePath} is being used by another process. Metadata Template is not exported.");
            }
        }

        // Load metadata from CSV file:
        private bool IsFileReadable(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    // Test if file is in-use by another process.
                }

                logForm.Logger(LogForm.LogType.INFO, $"{filePath} is accessible.");
                return false;
            }
            catch (IOException)
            {
                MessageBox.Show($"{filePath} is being used by another process.", "File In Use", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                logForm.Logger(LogForm.LogType.WARN, $"{filePath} is being used by another process.");
                return true;
            }
        }
        public void ImportMetadataViaCSV(DataGridView viewOrEditMetadataDataGridView, string metadataCsvFilePath)
        {
            if (IsFileReadable(metadataCsvFilePath))
            {
                return;
            }

            viewOrEditMetadataDataGridView.Rows.Clear();

            using (TextFieldParser csvParser = new TextFieldParser(metadataCsvFilePath))
            {
                csvParser.TextFieldType = FieldType.Delimited;
                csvParser.SetDelimiters(",");
                csvParser.HasFieldsEnclosedInQuotes = Properties.Settings.Default.MetadataHasQuotes;

                logForm.Logger(LogForm.LogType.INFO, $"CSV parser is set to comma delimited with \"HasFieldsEnclosedInQuotes\" set to {Properties.Settings.Default.MetadataHasQuotes}");

                if (csvParser.EndOfData)
                {
                    MessageBox.Show($"{metadataCsvFilePath} is empty, import cancelled.", "File Is Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    logForm.Logger(LogForm.LogType.WARN, $"{metadataCsvFilePath} is empty, import cancelled.");
                    return;
                }

                string[] csvHeaders = csvParser.ReadFields();
                string[] columnHeaders = viewOrEditMetadataDataGridView.Columns.Cast<DataGridViewColumn>().Select(col => col.HeaderText).ToArray();

                if (!csvHeaders.SequenceEqual(columnHeaders))
                {
                    MessageBox.Show($"CSV headers/columns mismatch, import cancelled.", "Column/Header Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    logForm.Logger(LogForm.LogType.WARN, $"CSV headers/columns mismatch, import cancelled.");
                    return;
                }

                while (!csvParser.EndOfData)
                {
                    string[] rowValues = csvParser.ReadFields();
                    viewOrEditMetadataDataGridView.Rows.Add(rowValues);
                }

                logForm.Logger(LogForm.LogType.INFO, $"Metadata imported via CSV.");
            }
        }

        // Ingest item information from DataGridView to issueMetadata :
        public void UpdateMetadata_Items(DataGridView viewOrEditMetadataDataGridView)
        {
            foreach (DataGridViewRow row in viewOrEditMetadataDataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                string item = row.Cells[0].Value?.ToString() ?? String.Empty;
                Issue newIssue = new Issue();
                newIssue.ITEM = item;
                newIssue.DATE_ISSUED = row.Cells[1].Value?.ToString() ?? String.Empty;
                newIssue.VOLUME = row.Cells[2].Value?.ToString() ?? String.Empty;
                newIssue.ISSUE = row.Cells[3].Value?.ToString() ?? String.Empty;
                newIssue.EDITION = row.Cells[4].Value?.ToString() ?? String.Empty;

                int pages = 0;
                if (int.TryParse(row.Cells[5].Value?.ToString() ?? String.Empty, out pages))
                {
                    newIssue.PAGES = pages;
                }
                else
                {
                    newIssue.PAGES = 0;
                }

                if (!mainForm.issueMetadata.ContainsKey(item))
                {
                    mainForm.issueMetadata.Add(item, newIssue);
                }

                logForm.Logger(LogForm.LogType.INFO, $"Item \"{item} -->" +
                    $"{newIssue.ITEM} - {newIssue.DATE_ISSUED} - Vol. {newIssue.VOLUME} - No. {newIssue.ISSUE} - Edition {newIssue.EDITION} - {newIssue.PAGES} pages\" loaded.");
            }
        }

        // Load JSON settings into ListBox:
        public void LoadJSONFilesIntoListBox(ListBox listBox, string folderPath)
        {
            string[] jsonFiles = Directory.GetFiles(folderPath, "*.json");

            listBox.Items.Clear();

            foreach (string jsonFile in jsonFiles)
            {
                logForm.Logger(LogForm.LogType.INFO, $"{jsonFile}");
                listBox.Items.Add(new JsonFileItem(jsonFile));
            }
        }

        //Validate if there is metadata for all the source files:
        //private void HaveMetadata()
        //{
        //    string sourceFileIssueNumber = String.Empty;

        //    List<ListViewItem> itemsWithNoMetadata = new List<ListViewItem>();

        //    foreach (ListViewItem sourceFileItem in mainForm.sourceFilesListView.Items)
        //    {
        //        string sourceFilePath = sourceFileItem.SubItems[0].Text;

        //        string sourceFileParentFolderName = Directory.GetParent(sourceFilePath).Name;
        //        string sourceFileParentFolderNameNormalized = sourceFileParentFolderName.Replace("-", "");
        //        string[] sourceFileParentFolderNameParts = sourceFileParentFolderNameNormalized.Split("_");


        //        if (sourceFileParentFolderNameParts.Length > 1)
        //        {
        //            sourceFileIssueNumber = sourceFileParentFolderNameParts[1] + Properties.Settings.Default.EditionOrder;
        //        }
        //        else
        //        {
        //            logForm.SendToLog(LogForm.LogType.ERROR, $"{sourceFileParentFolderName} contains illegal issue number in the folder name.");
        //        }

        //        if (!importEditMetadataForm.issueMetadata.ContainsKey(sourceFileIssueNumber))
        //        {
        //            string sourceFileName = Path.GetFileName(sourceFilePath);

        //            string destinationFilePath = Path.Combine(issuesWithNoMetadataFolderPath, sourceFileParentFolderName, sourceFileName);
        //            string destinationFolderPath = Path.GetDirectoryName(destinationFilePath);

        //            try
        //            {
        //                if (!Directory.Exists(destinationFolderPath))
        //                {
        //                    Directory.CreateDirectory(destinationFolderPath);
        //                }

        //                File.Move(sourceFilePath, destinationFilePath);
        //                itemsToRemove.Add(sourceFileItem);

        //                logForm.SendToLog(LogForm.LogType.INFO, $"Issue {sourceFileIssueNumber} has no metadata, relocating {sourceFilePath} to {destinationFilePath}.");
        //            }
        //            catch (IOException ex)
        //            {
        //                logForm.SendToLog(LogForm.LogType.ERROR, $"Relocating {sourceFilePath} to {destinationFilePath} encountered the following error: \"{ex.Message}\".");
        //            }
        //        }
        //    }
        //    logForm.SendToLog(LogForm.LogType.INFO, $"{itemsToRemove.Count} files will be removed from list.");

        //    foreach (ListViewItem itemToRemove in itemsToRemove)
        //    {
        //        sourceFilesListView.Items.Remove(itemToRemove);
        //    }
        //    logForm.SendToLog(LogForm.LogType.INFO, $"{itemsToRemove.Count} files have been removed from source file list.");
        //}



    }
}
