﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ASCMS.Domain.Data;

namespace ASCMS.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //ShadeTestBranch
        protected void Application_Start()
        {
            Database.SetInitializer<EFDbContext>(new ContextInitializer());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
