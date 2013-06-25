using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppHarbor_MVC4_POC.Models;

namespace AppHarbor_MVC4_POC.Controllers
{
    public class Test1Controller : Controller
    {
        private Test1Entities db = new Test1Entities();

        //
        // GET: /Test1/

        public ActionResult Index()
        {
            return View(db.vitals.ToList());
        }

        //
        // GET: /Test1/Details/5

        public ActionResult Details(int id = 0)
        {
            vital vital = db.vitals.Find(id);
            if (vital == null)
            {
                return HttpNotFound();
            }
            return View(vital);
        }

        //
        // GET: /Test1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Test1/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(vital vital)
        {
            if (ModelState.IsValid)
            {
                db.vitals.Add(vital);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vital);
        }

        //
        // GET: /Test1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            vital vital = db.vitals.Find(id);
            if (vital == null)
            {
                return HttpNotFound();
            }
            return View(vital);
        }

        //
        // POST: /Test1/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(vital vital)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vital).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vital);
        }

        //
        // GET: /Test1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            vital vital = db.vitals.Find(id);
            if (vital == null)
            {
                return HttpNotFound();
            }
            return View(vital);
        }

        //
        // POST: /Test1/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vital vital = db.vitals.Find(id);
            db.vitals.Remove(vital);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}