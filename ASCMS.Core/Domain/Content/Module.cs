using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCMS.Domain.Domain.Content
{
    public abstract class ModuleBody
    {

    }

    public partial class Module
    {
        [Key]
        public int ModuleId { get; set; }
        public ModuleType ModuleType { get; set; }
        public int ModuleWidth { get; set; }

        public ModuleBody GetModuleBody(ModuleType type)
        {
            if (type == ModuleType.HMLModule) return new HtmlModule();
            else if (type == ModuleType.EmptyModule) return new EmptyModule();
            else if (type == ModuleType.MenuModule) return new MenuModule();
            else return null;
        }
    }
}
