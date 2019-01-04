using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Antrian.Models;

namespace Antrian.Controllers
{
    public class HomeController : Controller
    {
        private AntrianEntities db = new AntrianEntities();
        public ActionResult Index()
        {
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
        public ActionResult Pelayanan()
        {
            ViewBag.Message = "Your contact page.";
            var bidang = db.BidangPelayanan.Include(p => p.Pelayanan);
            return View(bidang.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddAntrian([Bind(Include = "KodeAntrian,NoAntrian,Bidang,Pelayanan,Status,Loket")] AntrianPelayanan antrianPelayanan)
        {
            var kodeAntrian = db.AntrianPelayanan.Take(1).Select(a => a.KodeAntrian).SingleOrDefault();
            //if (ModelState.IsValid)
            //{
            //    //db.Entry(antrianPelayanan).State = EntityState.Modified;
            //    //db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            ViewBag.Message = "Added";
            return RedirectToAction("Pelayanan");
        }
    }
}