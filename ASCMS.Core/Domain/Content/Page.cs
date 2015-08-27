using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCMS.Domain.Domain.Content
{
    public partial class Page
    {
        private ICollection<PageRow> _pageRows;

        [Key]
        public int PageId { get; set; }

        public string PageTitle { get; set; }
        public string PageKeywords { get; set; }
        public string PageDescription { get; set; }

        public string PageName { get; set; }
        public string PageSEOName { get; set; }

        public virtual ICollection<PageRow> PageRows
        {
            
            get { return _pageRows ?? (_pageRows = new List<PageRow>()); }
            protected set { _pageRows = value; }
        }

    }
}
