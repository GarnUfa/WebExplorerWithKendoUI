using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEF_SQL.Model
{
    class Node
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        
        public Folder ParentFolder { get; set; }

        //public int? FileExtensionsModelID { get; set; } = 0;
    }
}
