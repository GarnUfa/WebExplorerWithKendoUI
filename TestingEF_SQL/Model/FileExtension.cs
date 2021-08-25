using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEF_SQL.Model
{
    class FileExtension
    {
        public int ID { get; set; }
        public string FileType { get; set; }
        public byte[] Icon { get; set; }
    }
}
