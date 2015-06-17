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
    public class InstituicaoController : Controller
    {
        private dbInfoXContext db = new dbInfoXContext();

        //
        // GET: /Instituicao/

        public ActionResult Index()
        {
            return View(db.Instituicao.ToList());
        }

        //
        // GET: /Instituicao/Details/5

        public ActionResult Details(int id = 0)
        {
            basInstituicao basinstituicao = db.Instituicao.Find(id);
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
                db.Instituicao.Add(basinstituicao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(basinstituicao);
        }

        //
        // GET: /Instituicao/Edit/5

        public ActionResult Edit(int id = 0)
        {
            basInstituicao basinstituicao = db.Instituicao.Find(id);
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
            basInstituicao basinstituicao = db.Instituicao.Find(id);
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
            basInstituicao basinstituicao = db.Instituicao.Find(id);
            db.Instituicao.Remove(basinstituicao);
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