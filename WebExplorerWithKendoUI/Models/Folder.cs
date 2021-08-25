using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebExplorerWithKendoUI.Models
{
    [Table("Folder")]
    class Folder : Node
    {
        public List<Node> Items { get; set; } = new List<Node>();
    }
}
