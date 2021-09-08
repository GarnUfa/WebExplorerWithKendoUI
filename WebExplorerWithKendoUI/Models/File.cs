using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebExplorerWithKendoUI.Models
{
    [Table("File")]
    public class File : Node
    {
        [Required]
        public string Description { get; set; }
        //public byte[] Content { get; set; }
    }
}
