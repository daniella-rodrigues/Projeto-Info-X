using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PI_INFOX.Models.Basicas;
using PagedList;

namespace PI_INFOX.Areas.Professor.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Professor/Home/

        public ActionResult Index(int? pagina)
        {

            dbInfoXContext db = new dbInfoXContext();
            var AvisosList = db.Aviso.OrderByDescending(x => x.dataPublicacao).ToList();
            int tamanhoPagina = 6;
            int numeroPagina = (pagina ?? 1);

            if (Session["usuarioLogadoID"] != null)
            {

                return View(AvisosList.ToPagedList(numeroPagina, tamanhoPagina));

            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Sobre()
        {
            return View();
        }
    }
}
