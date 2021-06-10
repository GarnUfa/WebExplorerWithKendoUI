using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Model
{
    class Folder
    {
        public int ID { get; set; }
        public string FolderName { get; set; }
        public int ParentFolderID { get; set; } = 1;
        public Folder ParentFolder { get; set; }
    }
}
