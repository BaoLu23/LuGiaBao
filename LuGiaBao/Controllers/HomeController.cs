using LuGiaBao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuGiaBao.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Index()
        {
            var all_phim = from s in db.Phims select s;
            return View(all_phim);
        }

        public ActionResult LichChieu()
        {
            var LichChieus = from s in db.LichChieux select s;

            return View(LichChieus);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}