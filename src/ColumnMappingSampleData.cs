using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchCreator.src
{
    public class ColumnMappingSampleData
    {
        public int ColumnNumber { get; set; }
        public string ColumnHeader { get; set; }
        public string ColumnSampleData { get; set; }
        public ColumnMappingSampleData(int columnNumber, string columnHeader, string columnSampleData)
        {
            ColumnNumber = columnNumber;
            ColumnHeader = columnHeader;
            ColumnSampleData = columnSampleData;
        }
    }
}
