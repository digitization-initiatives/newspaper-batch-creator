using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBatchAssemblyTool.src
{
    public class SourceFilesStructure
    {
        public string BatchDirectory { get; set; }
        public string IssueDirectory { get; set; }
        public string FileName { get; set; }
        public string FileNameWithoutExtension { get; set; }
        public string FileFullPath { get; set; }

        public SourceFilesStructure(string fileFullPath)
        {
            FileFullPath = fileFullPath;

            string directoryPath = Path.GetDirectoryName(fileFullPath);
            string[] folders = directoryPath.Split(Path.DirectorySeparatorChar);
            BatchDirectory = folders[0];
            IssueDirectory = folders[1];

            FileName = Path.GetFileName(fileFullPath);
            FileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileFullPath);
        }
    }
}
