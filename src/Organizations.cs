using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace NewspaperBatchCreator.src
{
    public class Organizations
    {
        [JsonPropertyName("organizationName")]
        public string ORGANIZATION_NAME {  get; set; }
        
        [JsonPropertyName("awardeeShortCode")]
        public string AWARDEE_SHORT_CODE { get; set; }

        [JsonPropertyName("awardYear")]
        public string AWARD_YEAR { get; set; }

        [JsonPropertyName("noteAboutReproduction")]
        public string NOTE_ABOUT_REPRODUCTION { get; set; }

        [JsonPropertyName("physicalLocation")]
        public string PHYSICAL_LOCATION { get; set; }

        [JsonPropertyName("physicalLocationDisplayLabel")]
        public string PHYSICAL_LOCATION_DISPLAY_LABEL { get; set; }

        [JsonPropertyName("agencyResponsibleForReproduction")]
        public string AGENCY_RESPONSIBLE_FOR_PRODUCTION { get; set; }

        [JsonPropertyName("agencyResponsibleForReproductionDisplayLabel")]
        public string AGENCY_RESPONSIBLE_FOR_PRODUCTION_DISPLAY_LABEL { get; set; }

        [JsonPropertyName("CompressionScheme")]
        public string COMPRESSION_SCHEME { get; set; }

        [JsonPropertyName("SamplingFrequencyUnit")]
        public string SAMPLING_FREQUENCY_UNIT { get; set; }

        [JsonPropertyName("XSamplingFrequency")]
        public string X_SAMPLING_FREQUENCY {  get; set; }

        [JsonPropertyName("YSamplingFrequency")]
        public string Y_SAMPLING_FREQUENCY { get; set; }
    }
}
