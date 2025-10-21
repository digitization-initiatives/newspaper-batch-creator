using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchCreator.src
{
    public class Batch_XML_Issue_Element
    {
        public string LCCN {  get; set; }
        public string ISSUE_DATE { get; set; }
        public string EDITION_ORDER { get; set; }
        public string ISSUE_XML_RELATIVE_PATH { get; set; }
        public string BATCH_XML_FILE_PATH { get; set; }
    }
}
