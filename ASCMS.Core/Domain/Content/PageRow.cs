using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCMS.Domain.Domain.Content
{
    public partial class PageRow
    {
        private ICollection<Module> _rowModules;

        [Key]
        public int PageRowId { get; set; }

        public virtual ICollection<Module> RowModules
        {
            get { return _rowModules ?? (_rowModules = new List<Module>()); }
            protected set { _rowModules = value; }
        }
    }
}
