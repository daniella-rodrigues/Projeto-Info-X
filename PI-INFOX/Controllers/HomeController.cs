using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Web;
using System.Web.Mvc;
using PI_INFOX.Models.Basicas;


namespace PI_INFOX.Controllers
{
    public class HomeController : Controller
    {
        //private dbInfoXContext db = new dbInfoXContext();
      
        public ActionResult Index()
        {
        //    var basforum = db.MensagemForums.Find(3);

        //    if (basforum == null)
        //    {
        //        return HttpNotFound();
        //    }
           return View();
           
        }


        public ActionResult Sobre()
        {
            return View();
        }

     

        public ActionResult Login(basUsuario u)
        {
            if (ModelState.IsValid)
            {
                using (dbInfoXContext db = new dbInfoXContext())
                {
                    var v = db.Usuario.Where(model => model.login.Equals(u.login) && model.senha.Equals(u.senha)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["usuarioLogadoID"] = v.UserID.ToString();
                        Session["nomeUsuarioLogado"] = v.nome.ToString();

                        switch (v.tipoUser)
                        {
                            case "ADMINISTRADOR":
                                return RedirectToAction("Index", "Home", new { area = "Admin" });
                            //break;
                            case "ALUNO":
                                return RedirectToAction("Index", "Home", new { area = "Aluno" });
                            //break;
                            case "PROFESSOR":
                                return RedirectToAction("Index", "Home", new { area = "Professor" });
                            //break;
                        }
                    }
                    else
                    {
                        ViewBag.Message = "O login ou senha não conferem, por favor digite novamente.";
                    }

                   
                }
            }
            
            return View(u);
        }
 
    }
}
