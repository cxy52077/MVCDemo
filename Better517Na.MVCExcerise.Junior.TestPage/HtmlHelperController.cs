using Better517Na.MVCExcerise.Junior.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Better517Na.MVCExcerise.Junior.Controllers
{
    /// <summary>
    /// HtmlHelperController演示类
    /// </summary>
    public class HtmlHelperController : Controller
    {
        public ActionResult HtmlHelper(VMStaffInfo staffInfo)
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView("HtmlHelperPartial", staffInfo);
            }
            staffInfo.Name = "我不是Ajax请求！";
            return View("HtmlHelper", staffInfo);
        }
    }
}
