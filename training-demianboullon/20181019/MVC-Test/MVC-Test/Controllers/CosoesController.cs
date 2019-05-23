using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Test.Models;

namespace MVC_Test.Controllers
{
    public class CosoesController : Controller
    {
        private MVC_DogsContext db = new MVC_DogsContext();

        // GET: Cosoes
        public ActionResult Index()
        {
            return View(db.Cosoes.ToList());
        }

        // GET: Cosoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coso coso = db.Cosoes.Find(id);
            if (coso == null)
            {
                return HttpNotFound();
            }
            return View(coso);
        }

        // GET: Cosoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cosoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age,Race")] Coso coso)
        {
            if (ModelState.IsValid)
            {
                db.Cosoes.Add(coso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coso);
        }

        // GET: Cosoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coso coso = db.Cosoes.Find(id);
            if (coso == null)
            {
                return HttpNotFound();
            }
            return View(coso);
        }

        // POST: Cosoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age,Race")] Coso coso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coso);
        }

        // GET: Cosoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coso coso = db.Cosoes.Find(id);
            if (coso == null)
            {
                return HttpNotFound();
            }
            return View(coso);
        }

        // POST: Cosoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Coso coso = db.Cosoes.Find(id);
            db.Cosoes.Remove(coso);
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
