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
    public class InstituicaoController : Controller
    {
        private dbInfoXContext db = new dbInfoXContext();

        //
        // GET: /Instituicao/

        public ActionResult Index()
        {
            return View(db.Instituicoes.ToList());
        }

        //
        // GET: /Instituicao/Details/5

        public ActionResult Details(int id = 0)
        {
            basInstituicao basinstituicao = db.Instituicoes.Find(id);
            if (basinstituicao == null)
            {
                return HttpNotFound();
            }
            return View(basinstituicao);
        }

        //
        // GET: /Instituicao/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Instituicao/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(basInstituicao basinstituicao)
        {
            if (ModelState.IsValid)
            {
                db.Instituicoes.Add(basinstituicao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(basinstituicao);
        }

        //
        // GET: /Instituicao/Edit/5

        public ActionResult Edit(int id = 0)
        {
            basInstituicao basinstituicao = db.Instituicoes.Find(id);
            if (basinstituicao == null)
            {
                return HttpNotFound();
            }
            return View(basinstituicao);
        }

        //
        // POST: /Instituicao/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(basInstituicao basinstituicao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(basinstituicao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(basinstituicao);
        }

        //
        // GET: /Instituicao/Delete/5

        public ActionResult Delete(int id = 0)
        {
            basInstituicao basinstituicao = db.Instituicoes.Find(id);
            if (basinstituicao == null)
            {
                return HttpNotFound();
            }
            return View(basinstituicao);
        }

        //
        // POST: /Instituicao/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            basInstituicao basinstituicao = db.Instituicoes.Find(id);
            db.Instituicoes.Remove(basinstituicao);
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