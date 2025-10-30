using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchCreator.src
{
    public class IssueMetadata
    {
        // Print issue metadata :
        public string ITEM {  get; set; }
        public string TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public string DATE { get; set; }
        public string VOLUME { get; set; }
        public string ISSUE { get; set; }
        public string EDITION { get; set; }
        public string PAGES { get; set; }

        // Reel isue metadat :
        public string REEL_NUMBER { get; set; }
        public string REEL_SEQUENCE_NUMBER { get; set; }

        public IssueMetadata()
        {
            ITEM = String.Empty;
            TITLE = String.Empty;
            DESCRIPTION = String.Empty;
            DATE = String.Empty;
            VOLUME = String.Empty;
            ISSUE = String.Empty;
            EDITION = String.Empty;
            PAGES = String.Empty;

            REEL_NUMBER = String.Empty;
            REEL_SEQUENCE_NUMBER = String.Empty;
        }
    }
}
