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

            Module EmptyModule = new Module();
            EmptyModule.ModuleType = ModuleType.EmptyModule;
            EmptyModule.ModuleWidth = 1;

            Module HtmlModule = new Module();
            HtmlModule.ModuleType = ModuleType.HMLModule;
            HtmlModule.ModuleWidth = 1;

            HtmlModule htm = new Domain.Content.HtmlModule();
            htm.HTMLText = "boo";
            htm.ParentModule = HtmlModule;
            //HtmlModule.ModuleBody = IModule(htm);

            Module MenuModule = new Module();
            MenuModule.ModuleType = ModuleType.MenuModule;
            MenuModule.ModuleWidth = 1;

            NewPageRow.RowModules.Add(EmptyModule);
            NewPageRow.RowModules.Add(HtmlModule);
            NewPageRow.RowModules.Add(MenuModule);
            NewPage.PageRows.Add(NewPageRow);

            context.Pages.Add(NewPage);
            context.PageRows.Add(NewPageRow);
            context.Modules.Add(EmptyModule);
            context.Modules.Add(HtmlModule);
            context.Modules.Add(MenuModule);

            context.HtmlModules.Add(htm);
            
            context.SaveChanges();
        }
    }

}
