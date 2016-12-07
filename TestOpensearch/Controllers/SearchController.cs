using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestOpensearch.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index(string q="")
        {
            return Content(q);
            //return View();
        }
    }
}