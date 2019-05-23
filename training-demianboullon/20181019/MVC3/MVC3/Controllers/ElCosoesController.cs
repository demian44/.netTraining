using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC3.Models;

namespace MVC3.Controllers
{
    public class ElCosoesController : Controller
    {
        private DogContext db = new DogContext();

        // GET: ElCosoes
        public ActionResult Index()
        {
            return View(db.ElCosoes.ToList());
        }

        // GET: ElCosoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElCoso elCoso = db.ElCosoes.Find(id);
            if (elCoso == null)
            {
                return HttpNotFound();
            }
            return View(elCoso);
        }

        // GET: ElCosoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ElCosoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Age,Name")] ElCoso elCoso)
        {
            if (ModelState.IsValid)
            {
                db.ElCosoes.Add(elCoso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(elCoso);
        }

        // GET: ElCosoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElCoso elCoso = db.ElCosoes.Find(id);
            if (elCoso == null)
            {
                return HttpNotFound();
            }
            return View(elCoso);
        }

        // POST: ElCosoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Age,Name")] ElCoso elCoso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(elCoso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(elCoso);
        }

        // GET: ElCosoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElCoso elCoso = db.ElCosoes.Find(id);
            if (elCoso == null)
            {
                return HttpNotFound();
            }
            return View(elCoso);
        }

        // POST: ElCosoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ElCoso elCoso = db.ElCosoes.Find(id);
            db.ElCosoes.Remove(elCoso);
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
