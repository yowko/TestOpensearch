using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestOpensearch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
			//sfdsdf23 sdfsdf=sdf1230 fsdlk'
			throw new exception();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}