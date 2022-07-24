using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace LaudaMusicam.Controllers
{
    public class LinksController : Controller
    {
        //
        // GET: /Links/

        public ActionResult Index()
        {
            return View("LinksIndex");
        }

    }
}
