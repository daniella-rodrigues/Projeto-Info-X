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
    public class VagasController : Controller
    {
        private dbInfoXContext db = new dbInfoXContext();

        //
        // GET: /Vagas/

        public ActionResult Index()
        {
            var vaga_estagio_emprego = db.Vaga_Estagio_Emprego.Include(b => b.Instituicao);
            return View(vaga_estagio_emprego.ToList());
        }

        //
        // GET: /Vagas/Details/5

        public ActionResult Details(int id = 0)
        {
            basVaga_Estagio_Emprego basvaga_estagio_emprego = db.Vaga_Estagio_Emprego.Find(id);
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
            ViewBag.matriculaInstituicaoID = new SelectList(db.Instituicoes, "matriculaInstituicaoID", "senha");
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
                db.Vaga_Estagio_Emprego.Add(basvaga_estagio_emprego);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.matriculaInstituicaoID = new SelectList(db.Instituicoes, "matriculaInstituicaoID", "senha", basvaga_estagio_emprego.matriculaInstituicaoID);
            return View(basvaga_estagio_emprego);
        }

        //
        // GET: /Vagas/Edit/5

        public ActionResult Edit(int id = 0)
        {
            basVaga_Estagio_Emprego basvaga_estagio_emprego = db.Vaga_Estagio_Emprego.Find(id);
            if (basvaga_estagio_emprego == null)
            {
                return HttpNotFound();
            }
            ViewBag.matriculaInstituicaoID = new SelectList(db.Instituicoes, "matriculaInstituicaoID", "senha", basvaga_estagio_emprego.matriculaInstituicaoID);
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
            ViewBag.matriculaInstituicaoID = new SelectList(db.Instituicoes, "matriculaInstituicaoID", "senha", basvaga_estagio_emprego.matriculaInstituicaoID);
            return View(basvaga_estagio_emprego);
        }

        //
        // GET: /Vagas/Delete/5

        public ActionResult Delete(int id = 0)
        {
            basVaga_Estagio_Emprego basvaga_estagio_emprego = db.Vaga_Estagio_Emprego.Find(id);
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
            basVaga_Estagio_Emprego basvaga_estagio_emprego = db.Vaga_Estagio_Emprego.Find(id);
            db.Vaga_Estagio_Emprego.Remove(basvaga_estagio_emprego);
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