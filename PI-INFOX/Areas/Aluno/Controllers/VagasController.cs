using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PI_INFOX.Models.Basicas;

namespace PI_INFOX.Areas.Aluno.Controllers
{
    public class VagasController : Controller
    {
        private dbInfoXContext db = new dbInfoXContext();

        //
        // GET: /Vagas/

        public ActionResult Index()
        {
            return View(db.Vagas.ToList());
        }

        //
        // GET: /Vagas/Details/5

        public ActionResult Details(int id = 0)
        {
            basVaga_Estagio_Emprego basvaga_estagio_emprego = db.Vagas.Find(id);
            if (basvaga_estagio_emprego == null)
            {
                return HttpNotFound();
            }
            return View(basvaga_estagio_emprego);
        }

        //
        // GET: /Vagas/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Vagas/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(basVaga_Estagio_Emprego basvaga_estagio_emprego)
        {
            if (ModelState.IsValid)
            {
                db.Vagas.Add(basvaga_estagio_emprego);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(basvaga_estagio_emprego);
        }

        //
        // GET: /Vagas/Edit/5

        public ActionResult Edit(int id = 0)
        {
            basVaga_Estagio_Emprego basvaga_estagio_emprego = db.Vagas.Find(id);
            if (basvaga_estagio_emprego == null)
            {
                return HttpNotFound();
            }
            return View(basvaga_estagio_emprego);
        }

        //
        // POST: /Vagas/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(basVaga_Estagio_Emprego basvaga_estagio_emprego)
        {
            if (ModelState.IsValid)
            {
                db.Entry(basvaga_estagio_emprego).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(basvaga_estagio_emprego);
        }

        //
        // GET: /Vagas/Delete/5

        public ActionResult Delete(int id = 0)
        {
            basVaga_Estagio_Emprego basvaga_estagio_emprego = db.Vagas.Find(id);
            if (basvaga_estagio_emprego == null)
            {
                return HttpNotFound();
            }
            return View(basvaga_estagio_emprego);
        }

        //
        // POST: /Vagas/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            basVaga_Estagio_Emprego basvaga_estagio_emprego = db.Vagas.Find(id);
            db.Vagas.Remove(basvaga_estagio_emprego);
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