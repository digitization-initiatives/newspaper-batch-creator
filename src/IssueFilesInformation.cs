using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchAssemblyTool.src
{
    public class IssueFilesInformation
    {
        public List<Jp2FileProperties> JP2_FILES { get; set; }
        public List<string> PDF_FILES { get; set; }
        public List<string> XML_FILES { get; set; }
        public string ISSUE_NUMBER { get; set; }
        public string ISSUE_XML_FILE_PATH { get; set; }
        public int NUMBER_OF_PAGES { get; set; }
        
        
        //For creating the issue xml file:
        public string ISSUE_METS_LABEL { get; set; } //mets section.
        public string ISSUE_CREATEDATE { get; set; } //metsHdr section.
        public string LCCN { get; set; } //dmdSec section - issueModsBib
        public string ISSUE_VOLUME_METADATA_RAW { get; set; }
        public string ISSUE_VOLUME { get; set; } //dmdSec section - issueModsBib
        public string ISSUE_VOLUME_NUMBER { get; set; } //dmdSec section - issueModsBib
        public string ISSUE_EDITION_ORDER { get; set; } //dmdSec section - issueModsBib
        public string ISSUE_DATE { get; set; } //dmdSec section - issueModsBib
    }
}
