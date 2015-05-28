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
    public class DisciplinaController : Controller
    {
        private dbInfoXContext db = new dbInfoXContext();

        //
        // GET: /Disciplina/

        public ActionResult Index()
        {
            return View(db.Disciplinas.ToList());
        }

        //
        // GET: /Disciplina/Details/5

        public ActionResult Details(int id = 0)
        {
            basDisciplina basdisciplina = db.Disciplinas.Find(id);
            if (basdisciplina == null)
            {
                return HttpNotFound();
            }
            return View(basdisciplina);
        }

        //
        // GET: /Disciplina/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Disciplina/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(basDisciplina basdisciplina)
        {
            if (ModelState.IsValid)
            {
                db.Disciplinas.Add(basdisciplina);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(basdisciplina);
        }

        //
        // GET: /Disciplina/Edit/5

        public ActionResult Edit(int id = 0)
        {
            basDisciplina basdisciplina = db.Disciplinas.Find(id);
            if (basdisciplina == null)
            {
                return HttpNotFound();
            }
            return View(basdisciplina);
        }

        //
        // POST: /Disciplina/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(basDisciplina basdisciplina)
        {
            if (ModelState.IsValid)
            {
                db.Entry(basdisciplina).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(basdisciplina);
        }

        //
        // GET: /Disciplina/Delete/5

        public ActionResult Delete(int id = 0)
        {
            basDisciplina basdisciplina = db.Disciplinas.Find(id);
            if (basdisciplina == null)
            {
                return HttpNotFound();
            }
            return View(basdisciplina);
        }

        //
        // POST: /Disciplina/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            basDisciplina basdisciplina = db.Disciplinas.Find(id);
            db.Disciplinas.Remove(basdisciplina);
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