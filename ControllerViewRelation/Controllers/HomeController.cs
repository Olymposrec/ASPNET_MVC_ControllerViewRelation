using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerViewRelation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Homepage()
        {
            ViewData["text1"]="Melih Akköse";
            ViewData["TD"] = true;

            ViewBag.team = "Beşiktaş JK";
            ViewBag.team2 = "Fenerbahçe SK";
            ViewBag.team3 = "Galatasaray SK";
            ViewBag.team4 = "Başakşehir SK";

            TempData["team5"] = "Liverpool FC";
            TempData["team6"] = "Manchester United FC";
            TempData["team7"] = "Manchester City FC";
            TempData["team8"] = "Tottenham FC";
            return View();
        }
        public ActionResult About()
        {

            ViewData["TDisim"] = "Melih Akköse";
            ViewBag.TDaktif = true;
            ViewBag.TDTakim = "Liverpool FC";

            ViewBag.team = "Beşiktaş JK";
            ViewBag.team2 = "Fenerbahçe SK";
            ViewBag.team3 = "Galatasaray SK";
            ViewBag.team4 = "Başakşehir SK";
            ViewBag.mesaj = "Bu mesaj hidden elementi için özel yazılmıştır.";
            ViewBag.check = true;
            ViewBag.check2 = false;
            ViewBag.Takimlar =
                new SelectListItem[]
                {
                    new SelectListItem(){Text="Liverpool FC"},
            new SelectListItem() { Text = "Manchester United FC" },
            new SelectListItem() { Text = "Manchester City FC" },
            new SelectListItem() { Text = "Tottenham FC" }
                };

            TempData["t"] = ViewBag.team;
            TempData["t2"] = ViewBag.team2;
            TempData["t3"] = ViewBag.team3;
            TempData["t4"] = ViewBag.team4;
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.team = TempData["t"];
            ViewBag.team2 = TempData["t2"];
            ViewBag.team3= TempData["t3"];
            ViewBag.team4 = TempData["t4"];

            return View();
        }
    }
}