using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchCreator.src
{
    internal class Utilities
    {
        private MainForm mainForm;
        private LogForm logForm;
        private SettingsForm settingsForm;

        internal Utilities(MainForm _mainForm, LogForm _logForm, SettingsForm _SettingsForm)
        {
            mainForm = _mainForm;
            logForm = _logForm;
            settingsForm = _SettingsForm;
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
