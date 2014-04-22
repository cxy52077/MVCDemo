using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Better517Na.MVCExcerise.Junior.Controllers
{
    /// <summary>
    /// Razor基本演示
    /// </summary>
    public class RazorBasicController:Controller
    {
        public ActionResult Index()
        {
            ViewBag.Jianjia = "蒹葭";
            return View();
        }
    }
}
