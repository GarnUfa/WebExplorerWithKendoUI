using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEF_SQL.Model
{
    [Table("File")]
    class File : Node
    {
        [Required]
        public string Description { get; set; }
        //public byte[] Content { get; set; }
    }
}
