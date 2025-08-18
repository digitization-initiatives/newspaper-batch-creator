using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchCreation.src
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

        //Validate if there is metadata for all the source files:
        private void HaveMetadata()
        {
            string sourceFileIssueNumber = String.Empty;

            List<ListViewItem> itemsWithNoMetadata = new List<ListViewItem>();

            foreach (ListViewItem sourceFileItem in mainForm.sourceFilesListView.Items)
            {
                string sourceFilePath = sourceFileItem.SubItems[0].Text;

                string sourceFileParentFolderName = Directory.GetParent(sourceFilePath).Name;
                string sourceFileParentFolderNameNormalized = sourceFileParentFolderName.Replace("-", "");
                string[] sourceFileParentFolderNameParts = sourceFileParentFolderNameNormalized.Split("_");


                if (sourceFileParentFolderNameParts.Length > 1)
                {
                    sourceFileIssueNumber = sourceFileParentFolderNameParts[1] + Properties.Settings.Default.EditionOrder;
                }
                else
                {
                    logForm.SendToLog(LogForm.LogType[LogForm.ERROR], $"{sourceFileParentFolderName} contains illegal issue number in the folder name.");
                }

                if (!importMetadataForm.issueMetadata.ContainsKey(sourceFileIssueNumber))
                {
                    string sourceFileName = Path.GetFileName(sourceFilePath);

                    string destinationFilePath = Path.Combine(issuesWithNoMetadataFolderPath, sourceFileParentFolderName, sourceFileName);
                    string destinationFolderPath = Path.GetDirectoryName(destinationFilePath);

                    try
                    {
                        if (!Directory.Exists(destinationFolderPath))
                        {
                            Directory.CreateDirectory(destinationFolderPath);
                        }

                        File.Move(sourceFilePath, destinationFilePath);
                        itemsToRemove.Add(sourceFileItem);

                        logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"Issue {sourceFileIssueNumber} has no metadata, relocating {sourceFilePath} to {destinationFilePath}.");
                    }
                    catch (IOException ex)
                    {
                        logForm.SendToLog(LogForm.LogType[LogForm.ERROR], $"Relocating {sourceFilePath} to {destinationFilePath} encountered the following error: \"{ex.Message}\".");
                    }
                }
            }
            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"{itemsToRemove.Count} files will be removed from list.");

            foreach (ListViewItem itemToRemove in itemsToRemove)
            {
                sourceFilesListView.Items.Remove(itemToRemove);
            }
            logForm.SendToLog(LogForm.LogType[LogForm.INFO], $"{itemsToRemove.Count} files have been removed from source file list.");
        }



    }
}
