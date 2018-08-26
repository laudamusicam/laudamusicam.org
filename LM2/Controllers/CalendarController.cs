using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaudaMusicam.Controllers
{
    public class CalendarController : Controller
    {
        public ActionResult Index()
        {
            return View("CalendarIndex");
        }
    }
}