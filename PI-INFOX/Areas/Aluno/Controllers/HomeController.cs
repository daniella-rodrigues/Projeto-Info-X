using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PI_INFOX.Areas.Aluno.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Aluno/Home/

        public ActionResult Index()
        {
            if (Session["usuarioLogadoID"] != null)
            {
                return View();
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
