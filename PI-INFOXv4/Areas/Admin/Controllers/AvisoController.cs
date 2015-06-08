using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PI_INFOX.Models.Basicas;

namespace PI_INFOX.Areas.Admin.Controllers
{
    public class AvisoController : Controller
    {
        private dbInfoXContext db = new dbInfoXContext();

        //
        // GET: /Admin/Aviso/

        public ActionResult Index()
        {
            var avisos = db.Aviso.Include(b => b.Disciplinas);
            return View(avisos.ToList());
        }

        //
        // GET: /Admin/Aviso/Details/5

        public ActionResult Details(int id = 0)
        {
            basAviso basaviso = db.Aviso.Find(id);
            if (basaviso == null)
            {
                return HttpNotFound();
            }
            return View(basaviso);
        }

        //
        // GET: /Admin/Aviso/Create

        public ActionResult Create()
        {
            ViewBag.DisciplinaID = new SelectList(db.Disciplina, "DisciplinaID", "nomeDisciplina");
            return View();
        }

        //
        // POST: /Admin/Aviso/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(basAviso basaviso)
        {
            if (ModelState.IsValid)
            {
                db.Aviso.Add(basaviso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DisciplinaID = new SelectList(db.Disciplina, "DisciplinaID", "nomeDisciplina", basaviso.DisciplinaID);
            return View(basaviso);
        }

        //
        // GET: /Admin/Aviso/Edit/5

        public ActionResult Edit(int id = 0)
        {
            basAviso basaviso = db.Aviso.Find(id);
            if (basaviso == null)
            {
                return HttpNotFound();
            }
            ViewBag.DisciplinaID = new SelectList(db.Disciplina, "DisciplinaID", "nomeDisciplina", basaviso.DisciplinaID);
            return View(basaviso);
        }

        //
        // POST: /Admin/Aviso/Edit/5

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
            ViewBag.DisciplinaID = new SelectList(db.Disciplina, "DisciplinaID", "nomeDisciplina", basaviso.DisciplinaID);
            return View(basaviso);
        }

        //
        // GET: /Admin/Aviso/Delete/5

        public ActionResult Delete(int id = 0)
        {
            basAviso basaviso = db.Aviso.Find(id);
            if (basaviso == null)
            {
                return HttpNotFound();
            }
            return View(basaviso);
        }

        //
        // POST: /Admin/Aviso/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            basAviso basaviso = db.Aviso.Find(id);
            db.Aviso.Remove(basaviso);
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