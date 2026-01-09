using DocumentFormat.OpenXml.Office.CoverPageProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchCreator.src
{
    public class Issue
    {
        public string ITEM { get; set; }

        // mets :
        public string LABEL { get; set; }

        // metsHdr :
        public string CREATEDATE { get; set; }
        public string ORGANIZATION_NAME { get; set; }

        // issueModsBib :
        public string LCCN { get; set; }
        public string VOLUME { get; set; }
        public string ISSUE { get; set; }
        public string EDITION { get; set; }
        public string DATE_ISSUED { get; set; }
        public string NOTE_ABOUT_REPRODUCTION { get; set; }

        // pageModsBib :
        public int PAGES { get; set; }
        public string PHYSICAL_LOCATION { get; set; }
        public string PHYSICAL_LOCATION_DISPLAY_LABEL { get; set; }
        public string AGENCY_RESPONSIBLE_FOR_PRODUCTION { get; set; }
        public string AGENCY_RESPONSIBLE_FOR_PRODUCTION_DISPLAY_LABEL { get; set; }

        // mixserviceFile :
        public string COMPRESSION_SCHEME { get; set; }
        public string SAMPLING_FREQUENCY_UNIT { get; set; }
        public int X_SAMPLING_FREQUENCY { get; set; }
        public int Y_SAMPLING_FREQUENCY { get; set; }

        //
        public List<Jp2FileAttributes> JP2_FILES { get; set; }
        public List<string> PDF_FILES { get; set; }
        public List<string> XML_FILES { get; set; }



        public Issue()
        {
            ITEM = String.Empty;
            DATE_ISSUED = String.Empty;
            VOLUME = String.Empty;
            ISSUE = String.Empty;
            EDITION = String.Empty;
            PAGES = 0;

            LABEL = String.Empty;
            ORGANIZATION_NAME = String.Empty;
            LCCN = String.Empty;
            NOTE_ABOUT_REPRODUCTION = String.Empty;
            PHYSICAL_LOCATION = String.Empty;
            PHYSICAL_LOCATION_DISPLAY_LABEL = String.Empty;
            AGENCY_RESPONSIBLE_FOR_PRODUCTION = String.Empty;
            AGENCY_RESPONSIBLE_FOR_PRODUCTION_DISPLAY_LABEL = String.Empty;
            COMPRESSION_SCHEME = String.Empty;
            SAMPLING_FREQUENCY_UNIT = String.Empty;
            X_SAMPLING_FREQUENCY = 0;
            Y_SAMPLING_FREQUENCY = 0;
        }
    }
}
