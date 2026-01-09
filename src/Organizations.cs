using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchCreator.src
{
    public class Organizations
    {
        public string ORGANIZATION_NAME {  get; set; }
        public string AWARDEE_SHORT_CODE { get; set; }
        public string AWARD_YEAR { get; set; }
        public string NOTE_ABOUT_REPRODUCTION { get; set; }
        public string PHYSICAL_LOCATION { get; set; }
        public string PHYSICAL_LOCATION_DISPLAY_LABEL { get; set; }
        public string AGENCY_RESPONSIBLE_FOR_PRODUCTION { get; set; }
        public string AGENCY_RESPONSIBLE_FOR_PRODUCTION_DISPLAY_LABEL { get; set; }
        public string COMPRESSION_SCHEME { get; set; }
        public string SAMPLING_FREQUENCY_UNIT { get; set; }
        public string X_SAMPLING_FREQUENCY {  get; set; }
        public string Y_SAMPLING_FREQUENCY { get; set; }
    }
}
