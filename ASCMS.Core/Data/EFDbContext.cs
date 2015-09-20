using System.Data.Entity;
using System.Linq;
using ASCMS.Domain.Domain.Content;

namespace ASCMS.Domain.Data
{
    public class EFDbContext: DbContext
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<PageRow> PageRows { get; set; }
        public DbSet<Module> Modules { get; set; }

        public DbSet<MenuModule> MenuModules { get; set; }
        public DbSet<EmptyModule> EmptyModules { get; set; }
        public DbSet<HtmlModule> HtmlModules { get; set; }
        
        public EFDbContext()
        {
        }
    }
}
