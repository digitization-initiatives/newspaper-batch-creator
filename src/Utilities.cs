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
        private LogForm logForm;

        internal Utilities(LogForm _logForm)
        {
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

                logForm.Logger(LogForm.LogType.INFO, $"${filePath} is accessible.");
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
