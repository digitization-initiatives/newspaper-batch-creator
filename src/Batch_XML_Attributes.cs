using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchCreator.src
{
    public class Batch_XML_Attributes
    {
        public string XML_VERSION = @"<?xml version=""1.0"" encoding=""UTF-8""?>";
        public string BATCH_PREFIX = "ndnp";
        public string BATCH_ELEMENT = "batch";
        public string XMLNS_NDNP = "http://www.loc.gov/ndnp";
        public string XMLNS_XSI = "http://www.w3.org/2001/XMLSchema-instance";
        public string XMLNS = "http://www.loc.gov/ndnp";

        public string BATCH_NAME {  get; set; }
        public string AWARDEE { get; set; }
        public string AWARD_YEAR { get; set; }
        public string BATCH_XML_FILE_PATH { get; set; }
    }
}
