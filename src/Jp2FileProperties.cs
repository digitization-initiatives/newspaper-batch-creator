using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchAssemblyTool.src
{
    public class Jp2FileProperties
    {
        public string JP2_FILE_PATH { get; set; }
        public string COMPRESSION_SCHEME { get; set; }
        public string SAMPLING_FREQUENCY_UNIT { get; set; }
        public string X_SAMPLING_FREQUENCY { get; set; }
        public string Y_SAMPLING_FREQUENCY { get; set;}
        public string IMAGE_WIDTH { get; set; }
        public string IMAGE_LENGTH { get; set; }
    }
}
