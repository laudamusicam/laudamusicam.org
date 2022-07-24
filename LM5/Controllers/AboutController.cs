using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace LaudaMusicam.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return View("AboutIndex");
        }
    }
}
