using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchCreator.src
{
    public class BatchIssueElementMetadata
    {
        public string LCCN_ATTR {  get; set; }
        public string ISSUE_DATE_ATTR { get; set; }
        public string EDITION_ORDER_ATTR { get; set; }

        public string ISSUE_XML_RELATIVE_PATH { get; set; }
        public string BATCH_XML_FILE_PATH { get; set; }
    }
}
