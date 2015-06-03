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

        public ActionResult Login()
        {
            return View();
        }
 
    }
}
