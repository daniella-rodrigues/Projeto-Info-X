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
    public class ForumController : Controller
    {
        private dbInfoXContext db = new dbInfoXContext();

        //
        // GET: /Forum/

        public ActionResult Index()
        {
            var forums = db.Forum.Include(b => b.Disciplina);
            return View(forums.ToList());
        }

        //
        // GET: /Forum/Details/5

        public ActionResult Details(int id = 0)
        {
            basForum basforum = db.Forum.Find(id);
            if (basforum == null)
            {
                return HttpNotFound();
            }
            return View(basforum);
        }

        //
        // GET: /Forum/Create

        public ActionResult Create()
        {
            ViewBag.DisciplinaID = new SelectList(db.Disciplina, "DisciplinaID", "nomeDisciplina");
            return View();
        }

        //
        // POST: /Forum/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(basForum basforum)
        {
            if (ModelState.IsValid)
            {
                db.Forum.Add(basforum);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DisciplinaID = new SelectList(db.Disciplina, "DisciplinaID", "nomeDisciplina", basforum.DisciplinaID);
            return View(basforum);
        }

        //
        // GET: /Forum/Edit/5

        public ActionResult Edit(int id = 0)
        {
            basForum basforum = db.Forum.Find(id);
            if (basforum == null)
            {
                return HttpNotFound();
            }
            ViewBag.DisciplinaID = new SelectList(db.Disciplina, "DisciplinaID", "nomeDisciplina", basforum.DisciplinaID);
            return View(basforum);
        }

        //
        // POST: /Forum/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(basForum basforum)
        {
            if (ModelState.IsValid)
            {
                db.Entry(basforum).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DisciplinaID = new SelectList(db.Disciplina, "DisciplinaID", "nomeDisciplina", basforum.DisciplinaID);
            return View(basforum);
        }

        //
        // GET: /Forum/Delete/5

        public ActionResult Delete(int id = 0)
        {
            basForum basforum = db.Forum.Find(id);
            if (basforum == null)
            {
                return HttpNotFound();
            }
            return View(basforum);
        }

        //
        // POST: /Forum/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            basForum basforum = db.Forum.Find(id);
            db.Forum.Remove(basforum);
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