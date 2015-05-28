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
    public class AlunoController : Controller
    {
        private dbInfoXContext db = new dbInfoXContext();

        //
        // GET: /Aluno/

        public ActionResult Index()
        {
            var alunos = db.Alunos.Include(b => b.Instituicao).Include(b => b.Disciplinas);
            return View(alunos.ToList());
        }

        //
        // GET: /Aluno/Details/5

        public ActionResult Details(int id = 0)
        {
            basAluno basaluno = db.Alunos.Find(id);
            if (basaluno == null)
            {
                return HttpNotFound();
            }
            return View(basaluno);
        }

        //
        // GET: /Aluno/Create

        public ActionResult Create()
        {
            ViewBag.matriculaInstituicaoID = new SelectList(db.Instituicoes, "matriculaInstituicaoID", "senha");
            ViewBag.DisciplinaID = new SelectList(db.Disciplinas, "DisciplinaID", "nomeDisciplina");
            return View();
        }

        //
        // POST: /Aluno/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(basAluno basaluno)
        {
            if (ModelState.IsValid)
            {
                db.Alunos.Add(basaluno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.matriculaInstituicaoID = new SelectList(db.Instituicoes, "matriculaInstituicaoID", "senha", basaluno.matriculaInstituicaoID);
            ViewBag.DisciplinaID = new SelectList(db.Disciplinas, "DisciplinaID", "nomeDisciplina", basaluno.DisciplinaID);
            return View(basaluno);
        }

        //
        // GET: /Aluno/Edit/5

        public ActionResult Edit(int id = 0)
        {
            basAluno basaluno = db.Alunos.Find(id);
            if (basaluno == null)
            {
                return HttpNotFound();
            }
            ViewBag.matriculaInstituicaoID = new SelectList(db.Instituicoes, "matriculaInstituicaoID", "senha", basaluno.matriculaInstituicaoID);
            ViewBag.DisciplinaID = new SelectList(db.Disciplinas, "DisciplinaID", "nomeDisciplina", basaluno.DisciplinaID);
            return View(basaluno);
        }

        //
        // POST: /Aluno/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(basAluno basaluno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(basaluno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.matriculaInstituicaoID = new SelectList(db.Instituicoes, "matriculaInstituicaoID", "senha", basaluno.matriculaInstituicaoID);
            ViewBag.DisciplinaID = new SelectList(db.Disciplinas, "DisciplinaID", "nomeDisciplina", basaluno.DisciplinaID);
            return View(basaluno);
        }

        //
        // GET: /Aluno/Delete/5

        public ActionResult Delete(int id = 0)
        {
            basAluno basaluno = db.Alunos.Find(id);
            if (basaluno == null)
            {
                return HttpNotFound();
            }
            return View(basaluno);
        }

        //
        // POST: /Aluno/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            basAluno basaluno = db.Alunos.Find(id);
            db.Alunos.Remove(basaluno);
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