using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PI_INFOX.Models.Basicas;

namespace PI_INFOX.Controllers
{
    public class AvisoController : Controller
    {
        private dbInfoXContext db = new dbInfoXContext();

        //
        // GET: /Aviso/

        public ActionResult Index()
        {
            return View(db.Avisos.ToList());
        }

        //
        // GET: /Aviso/Details/5

        public ActionResult Details(int id = 0)
        {
            basAviso basaviso = db.Avisos.Find(id);
            if (basaviso == null)
            {
                return HttpNotFound();
            }
            return View(basaviso);
        }

        //
        // GET: /Aviso/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Aviso/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(basAviso basaviso)
        {
            if (ModelState.IsValid)
            {
                db.Avisos.Add(basaviso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(basaviso);
        }

        //
        // GET: /Aviso/Edit/5

        public ActionResult Edit(int id = 0)
        {
            basAviso basaviso = db.Avisos.Find(id);
            if (basaviso == null)
            {
                return HttpNotFound();
            }
            return View(basaviso);
        }

        //
        // POST: /Aviso/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(basAviso basaviso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(basaviso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(basaviso);
        }

        //
        // GET: /Aviso/Delete/5

        public ActionResult Delete(int id = 0)
        {
            basAviso basaviso = db.Avisos.Find(id);
            if (basaviso == null)
            {
                return HttpNotFound();
            }
            return View(basaviso);
        }

        //
        // POST: /Aviso/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            basAviso basaviso = db.Avisos.Find(id);
            db.Avisos.Remove(basaviso);
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