using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchCreator.src
{
    internal class JsonFileItem
    {
        public string FILE_PATH {  get; set; }
        public JsonFileItem(string _file_path)
        {
            FILE_PATH = _file_path;
        }

        public override string ToString()
        {
            return Path.GetFileName(FILE_PATH);
        }
    }
}
