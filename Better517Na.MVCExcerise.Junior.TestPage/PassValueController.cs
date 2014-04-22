using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Better517Na.MVCExcerise.Junior.Controllers
{
    public class PassValueController : Controller
    {
        public string Index()
        {
            return "Just for fun!";
        }

        public ActionResult PassValue()
        {
            //return View("PassValue");
            return View("../RazorShow/PassValue");
        }
    }
}
