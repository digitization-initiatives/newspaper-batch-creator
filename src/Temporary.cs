using System;
using System.Collections.Generic;
using System.Drawing.Interop;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NewspaperBatchCreator.src
{
    internal class Temporary
    {
        //private void lccnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (settingsForm.selectLccnComboBox.SelectedIndex != -1)
        //    {
        //        Properties.Settings.Default.SeletedLccn = selectLccnComboBox.SelectedItem.ToString().Substring(0, 10);
        //        Properties.Settings.Default.Save();

        //        //Automatically populate the BATCH_PREFIX based on selected LCCN:
        //        LCCN_PROPERTIES lccnProperties;
        //        LCCN.LCCN_ITEMS.TryGetValue(Properties.Settings.Default.SeletedLccn, out lccnProperties);
        //        batchNamePrefixTextBox.Text = lccnProperties.BATCH_PREFIX;

        //        //Set award year based on selected LCCN:
        //        switch (Properties.Settings.Default.SeletedLccn)
        //        {
        //            case "sn37020267":
        //                Properties.Settings.Default.AwardYear = "2020";
        //                Properties.Settings.Default.Save();
        //                logForm.SendToLog(LogForm.LogType.INFO, $"AwardYear for \"{selectLccnComboBox.SelectedItem}\" is set to {Properties.Settings.Default.AwardYear}.");
        //                break;
        //            case "sn86088544":
        //                Properties.Settings.Default.AwardYear = "2015";
        //                Properties.Settings.Default.Save();
        //                logForm.SendToLog(LogForm.LogType.INFO, $"AwardYear for \"{selectLccnComboBox.SelectedItem}\" is set to {Properties.Settings.Default.AwardYear}.");
        //                break;
        //            case "sn88037063":
        //                Properties.Settings.Default.AwardYear = "2020";
        //                Properties.Settings.Default.Save();
        //                logForm.SendToLog(LogForm.LogType.INFO, $"AwardYear for \"{selectLccnComboBox.SelectedItem}\" is set to {Properties.Settings.Default.AwardYear}.");
        //                break;
        //            default:
        //                Properties.Settings.Default.AwardYear = String.Empty;
        //                Properties.Settings.Default.Save();
        //                logForm.SendToLog(LogForm.LogType.INFO, $"No newspaper is selected. AwardYear is set to String.Empty.");
        //                break;
        //        }

        //    }
        //}


        //private bool validate_batchNumberTextBox()
        //{
        //    return Regex.IsMatch(batchNumberTextBox.Text, @"^\d+$");
        //}



    }
}
