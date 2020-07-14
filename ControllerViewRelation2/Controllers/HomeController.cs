using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerViewRelation2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Homepage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Homepage(string text1, string text2, string text3, bool check1, string list1)
        {
            var cevap = Request.Form["text1"];
            var cevap2 = Request.Form["text2"];
            var cevap3 = Request.Form["text3"];
            var cevap4 = Request.Form["list1"];
            var check = Request.Form.GetValues("check1")[0];
            
            return View();
        }
    }
}