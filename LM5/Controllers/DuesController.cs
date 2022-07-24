using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace LM2.Controllers
{
    public class DuesController : Controller
    {
        // GET: PaymentSuccess
        public ActionResult Index()
        {
            return View("DueIndex");
        }
    }
}