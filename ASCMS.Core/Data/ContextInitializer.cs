using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Data.Entity.Validation;
using ASCMS.Domain.Domain.Content;

namespace ASCMS.Domain.Data
{
    //public class ContextInitializer : CreateDatabaseIfNotExists<EFDbContext>
    public class ContextInitializer : DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            Page NewPage = new Page();

            NewPage.PageSEOName = "Default";
            NewPage.PageTitle = "Тестовая страница";
            
            PageRow NewPageRow = new PageRow();

            Module NewModule = new Module();
            NewModule.ModuleType = ModuleType.EmptyModule;
            NewModule.ModuleWidth = 1;
            
            NewPageRow.RowModules.Add(NewModule);
            NewPage.PageRows.Add(NewPageRow);

            context.Pages.Add(NewPage);
            context.PageRows.Add(NewPageRow);
            context.Modules.Add(NewModule);
            context.SaveChanges();
        }
    }

}
