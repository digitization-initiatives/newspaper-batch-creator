using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchCreator.src
{
    public class Batch
    {
        public string XML_VERSION = @"<?xml version=""1.0"" encoding=""UTF-8""?>";
        public string NDNP_BATCH_ELEMENT = "ndnp:batch";
        public string XMLNS_NDNP_ATTR = "http://www.loc.gov/ndnp";
        public string XMLNS_XSI_ATTR = "http://www.w3.org/2001/XMLSchema-instance";
        public string XMLNS_ATTR = "http://www.loc.gov/ndnp";
        
        public string NAME_ATTR {  get; set; }
        public string AWARDEE_ATTR { get; set; }
        public string AWARD_YEAR_ATTR { get; set; }
        
        public string BATCH_XML_FILE_PATH { get; set; }
    }
}
