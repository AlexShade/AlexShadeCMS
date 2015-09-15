using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASCMS.Domain.Data;
using ASCMS.Domain.Domain.Content;

namespace ASCMS.Web.Controllers
{
    public class PageController : Controller
    {
        private EFDbContext context { get; set; }
        // GET: Page
        public ActionResult Index(string PageSEOName)
        {
            context = new EFDbContext();
             
            Page ResPage = context.Pages.First();

            return View(ResPage);
        }

        public PartialViewResult PageModule(Module pm)
        {
            return PartialView(pm);
        }
    }
}