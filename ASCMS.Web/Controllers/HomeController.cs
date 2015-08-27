using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASCMS.Domain.Data;
using ASCMS.Domain.Domain.Content;

namespace ASCMS.Web.Controllers
{
    public class HomeController : Controller
    {
        private EFDbContext context { get; set; }

        // GET: Home
        public ActionResult Index()
        {
            context = new EFDbContext();
            List<Page> Pages = context.Pages.ToList();

            return View();
        }
    }
}