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
    /// Razor展示
    /// </summary>
    public class RazorShowController : Controller
    {
        public ActionResult RazorView(string Name)
        {
            FormCollection coll = new FormCollection();
            string test = Request.QueryString["Name"];
            string name = coll["Name"] != null ? coll["Name"].ToString().Trim() : string.Empty;
            string sex = coll["Sex"] != null ? coll["Sex"].ToString().Trim() : string.Empty;
            int position = coll["Position"] != null ? Convert.ToInt32(coll["Position"].ToString().Trim()) : 0;
            int age = coll["Age"] != null ? Convert.ToInt32(coll["Age"].ToString().Trim()) : 0;

            ViewData["name"] = name;
            ViewData["sex"] = sex;
            ViewData["slt"] = position;
            ViewData["age"] = age;
            ViewBag.newCommer = "I'm a new Commner!";
            ViewBag.woyaoquna = "0000";
            //return View("RazorView");

            VMStaffInfo staffInfo = new VMStaffInfo();
            staffInfo.Name = name;
            staffInfo.Sex = sex;
            staffInfo.Position = position;
            staffInfo.Age = age;

            return View(staffInfo);
            //return View("/Static/HtmlPage1.html");
        }

        /// <summary>
        /// 显式与隐式模型绑定
        /// </summary>
        /// <returns></returns>
        public ActionResult NiceCatch(VMStaffInfo staffInfo)// 参数传入，执行的是tryUpdate。 string txtName, string sex, string sltPosition, int txtAge = 0 
        {
            //VMStaffInfo staffInfo = new VMStaffInfo();
            //UpdateModel(staffInfo);
            bool check = ModelState.IsValid;// 通过模型状态来判断绑定成功与否
            return View("RazorView", staffInfo);
        }
    }
}
