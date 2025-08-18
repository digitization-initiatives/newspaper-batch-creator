using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchCreation.src
{
    public class IssueMetadata
    {
        //Properties provided in column mapping DataGridView:
        public string ISSUE_NUMBER { get; set; }
        public string TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public string DATE { get; set; } 
        public string VOLUME { get; set; }
        public string FREQUENCY { get; set; }
        public string NUMBER_OF_PAGES { get; set; }
        public string REEL_NUMBER { get; set; }
        public string REEL_SEQUENCE_NUMBER { get; set; }
        public string DC_SUBJECT_INSTITUTION { get; set; }
        public string DC_SUBJECT_COLLEGE {  get; set; }
        public string DC_SUBJECT_LOCATION { get; set; }
        public string DC_CONTRIBUTOR_COLLEGE { get; set; }
        public string DC_CONTRIBUTOR_INSTITUTION { get; set; }
        public string DC_COVERAGE { get; set; }
        public string DC_PUBLISHER { get; set; }
        public string DC_LANGUAGE { get; set; }
        public string DC_FORMAT { get; set; }
        public string DC_TYPE { get; set; }
        public string DC_RIGHTS { get; set; }
    }
}
