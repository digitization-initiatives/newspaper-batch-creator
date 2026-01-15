using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NewspaperBatchCreator.src
{
    public class Titles
    {
        [JsonPropertyName("lccn")]
        public string LCCN {  get; set; }

        [JsonPropertyName("title")]
        public string TITLE { get; set; }

        [JsonPropertyName("batchNamePrefix")]
        public string BATCH_NAME_PREFIX { get; set; }

        [JsonPropertyName("batchNumber")]
        public string BATCH_NUMBER {  get; set; }
    }
}
