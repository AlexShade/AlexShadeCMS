using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCMS.Domain.Domain.Content
{
    public partial class Module
    {
        [Key]
        public int ModuleId { get; set; }
        public ModuleType ModuleType { get; set; }
        public int ModuleWidth { get; set; }
    }
}
