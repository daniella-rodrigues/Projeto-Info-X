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
    public class ContatoController : Controller
    {
        private dbInfoXContext db = new dbInfoXContext();

        //
        // GET: /Contato/

        public ActionResult Index()
        {
            return View(db.Contatos.ToList());
        }

        //
        // GET: /Contato/Details/5

        public ActionResult Details(int id = 0)
        {
            basContato bascontato = db.Contatos.Find(id);
            if (bascontato == null)
            {
                return HttpNotFound();
            }
            return View(bascontato);
        }

        //
        // GET: /Contato/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Contato/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(basContato bascontato)
        {
            if (ModelState.IsValid)
            {
                db.Contatos.Add(bascontato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bascontato);
        }

        //
        // GET: /Contato/Edit/5

        public ActionResult Edit(int id = 0)
        {
            basContato bascontato = db.Contatos.Find(id);
            if (bascontato == null)
            {
                return HttpNotFound();
            }
            return View(bascontato);
        }

        //
        // POST: /Contato/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(basContato bascontato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bascontato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bascontato);
        }

        //
        // GET: /Contato/Delete/5

        public ActionResult Delete(int id = 0)
        {
            basContato bascontato = db.Contatos.Find(id);
            if (bascontato == null)
            {
                return HttpNotFound();
            }
            return View(bascontato);
        }

        //
        // POST: /Contato/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            basContato bascontato = db.Contatos.Find(id);
            db.Contatos.Remove(bascontato);
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