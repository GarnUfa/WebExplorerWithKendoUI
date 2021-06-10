using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Model
{
    class File
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public int FileExtensionID { get; set; } = 1;
        public FileExtension FileExtension { get; set; }
        public int ParentFolderID { get; set; } = 1;
        public Folder ParentFolder { get; set; }
        public byte[] Content { get; set; }
    }
}
