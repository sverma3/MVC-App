﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class ErrorController : Controller
    {
        [RequireHttps]
        public ActionResult NotFound()
        {
           return View();
        }
    }
}
