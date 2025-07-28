using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchCreation.src
{
    public class LCCN
    {
        public static readonly Dictionary<string, LCCN_PROPERTIES> LCCN_ITEMS = new Dictionary<string, LCCN_PROPERTIES>
        {
            //Texas A&M Newspapers
            { "sn37020267", new LCCN_PROPERTIES { TITLE = "The Daily Bulletin/Reveille.", BATCH_PREFIX = "batch_txa_daily_ver" } },
            { "sn86088544", new LCCN_PROPERTIES { TITLE = "The Battalion.", BATCH_PREFIX = "batch_txa_batt_ver" } },
            { "sn88037063", new LCCN_PROPERTIES { TITLE = "The Texas Polka News.", BATCH_PREFIX = "batch_txa_polka_ver" } },
            { "sn84009780", new LCCN_PROPERTIES { TITLE = "The Texas Aggie.", BATCH_PREFIX = "batch_txa_aggie_ver" } }
        };
    }
}
