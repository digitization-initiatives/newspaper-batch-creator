using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
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
                        columnMappingDataGridView.Rows[rowId].Cells[sampleDataCol.Index].Value = sampleDataRow.Cell(i).Value;
                    }
                }
            }

        }

        #endregion

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void selectMetadataFileButton_Click(object sender, EventArgs e)
        {
            if (selectMetadataFile_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectmetadataFileTextBox.Text = selectMetadataFile_openFileDialog.FileName;
                loadColumnMappingSampleData();
            }
            else
            {
                selectmetadataFileTextBox.Text = String.Empty;
            }
        }
    }
}
