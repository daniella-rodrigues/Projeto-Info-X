using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PI_INFOX.Models.Basicas;

namespace PI_INFOX.Areas.Professor.Controllers
{
    public class MaterialController : Controller
    {
        private dbInfoXContext db = new dbInfoXContext();

        //
        // GET: /Material/

        public ActionResult Index()
        {
            var materiais = db.Material.Include(b => b.Disciplinas);
            return View(materiais.ToList());
        }

        //
        // GET: /Material/Details/5

        public ActionResult Details(int id = 0)
        {
            basMaterial basmaterial = db.Material.Find(id);
            if (basmaterial == null)
            {
                return HttpNotFound();
            }
            return View(basmaterial);
        }

        //
        // GET: /Material/Create

        public ActionResult Create()
        {
            var userid = (Session["usuarioLogadoID"]);
            var id = Convert.ToInt32(userid);
            basUsuario basusuario = db.Usuario.Find(id);
            if (basusuario == null)
            {

            }

            ViewBag.DisciplinaID = new SelectList(db.Usuario, "DisciplinaID", "DisciplinaID", basusuario.DisciplinaID);
            return View();
        }

        //
        // POST: /Material/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(basMaterial basmaterial)
        {
            if (ModelState.IsValid)
            {
                db.Material.Add(basmaterial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DisciplinaID = new SelectList(db.Disciplina, "DisciplinaID", "nomeDisciplina", basmaterial.DisciplinaID);
            return View(basmaterial);
        }

        //
        // GET: /Material/Edit/5

        public ActionResult Edit(int id = 0)
        {
            basMaterial basmaterial = db.Material.Find(id);
            if (basmaterial == null)
            {
                return HttpNotFound();
            }
            ViewBag.DisciplinaID = new SelectList(db.Disciplina, "DisciplinaID", "nomeDisciplina", basmaterial.DisciplinaID);
            return View(basmaterial);
        }

        //
        // POST: /Material/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(basMaterial basmaterial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(basmaterial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DisciplinaID = new SelectList(db.Disciplina, "DisciplinaID", "nomeDisciplina", basmaterial.DisciplinaID);
            return View(basmaterial);
        }

        //
        // GET: /Material/Delete/5

        public ActionResult Delete(int id = 0)
        {
            basMaterial basmaterial = db.Material.Find(id);
            if (basmaterial == null)
            {
                return HttpNotFound();
            }
            return View(basmaterial);
        }

        //
        // POST: /Material/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            basMaterial basmaterial = db.Material.Find(id);
            db.Material.Remove(basmaterial);
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