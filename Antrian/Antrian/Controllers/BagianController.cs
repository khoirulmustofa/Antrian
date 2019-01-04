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
    public class BagianController : Controller
    {
        private AntrianEntities db = new AntrianEntities();

        // GET: /Bagian/
        public ActionResult Index()
        {
            return View(db.BidangPelayanan.ToList());
        }

        // GET: /Bagian/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BidangPelayanan bidangpelayanan = db.BidangPelayanan.Find(id);
            if (bidangpelayanan == null)
            {
                return HttpNotFound();
            }
            return View(bidangpelayanan);
        }

        // GET: /Bagian/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Bagian/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="BidangId,NamaBidangPelayanan,Loket")] BidangPelayanan bidangpelayanan)
        {
            if (ModelState.IsValid)
            {
                db.BidangPelayanan.Add(bidangpelayanan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bidangpelayanan);
        }

        // GET: /Bagian/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BidangPelayanan bidangpelayanan = db.BidangPelayanan.Find(id);
            if (bidangpelayanan == null)
            {
                return HttpNotFound();
            }
            return View(bidangpelayanan);
        }

        // POST: /Bagian/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="BidangId,NamaBidangPelayanan,Loket")] BidangPelayanan bidangpelayanan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bidangpelayanan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bidangpelayanan);
        }

        // GET: /Bagian/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BidangPelayanan bidangpelayanan = db.BidangPelayanan.Find(id);
            if (bidangpelayanan == null)
            {
                return HttpNotFound();
            }
            return View(bidangpelayanan);
        }

        // POST: /Bagian/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BidangPelayanan bidangpelayanan = db.BidangPelayanan.Find(id);
            db.BidangPelayanan.Remove(bidangpelayanan);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
