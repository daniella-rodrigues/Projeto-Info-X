using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PI_INFOX.Models.Basicas;
using PagedList;

namespace PI_INFOX.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Admin/Home/    
         private dbInfoXContext db = new dbInfoXContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NoticiasAvisos(int? pagina)
        {

            var AvisosList = db.Aviso.OrderByDescending(x => x.DataCadastro).ToList();
            int tamanhoPagina = 6;
            int numeroPagina = (pagina ?? 1);

            return PartialView(AvisosList.ToPagedList(numeroPagina, tamanhoPagina));

        }


        public ActionResult NoticiasForum(int? pagina)
        {

            var ForumList = db.Forum.OrderByDescending(x => x.DataCadastro).ToList();
            int tamanhoPagina = 4;
            int numeroPagina = (pagina ?? 1);

            return PartialView(ForumList.ToPagedList(numeroPagina, tamanhoPagina));

        }

        public ActionResult NoticiasMaterial(int? pagina)
        {

            var MaterialList = db.Material.OrderByDescending(x => x.DataCadastro).ToList();
            int tamanhoPagina = 4;
            int numeroPagina = (pagina ?? 1);

            return PartialView(MaterialList.ToPagedList(numeroPagina, tamanhoPagina));

        }

        public ActionResult NoticiasVagas(int? pagina)
        {

            var VagasList = db.Vagas.OrderByDescending(x => x.DataCadastro).ToList();
            int tamanhoPagina = 4;
            int numeroPagina = (pagina ?? 1);

            return PartialView(VagasList.ToPagedList(numeroPagina, tamanhoPagina));

        }

        public ActionResult Sobre()
        {
            return View();
        }

        public ActionResult Logoff()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home", new { Area = "" });
        }
    }
}
