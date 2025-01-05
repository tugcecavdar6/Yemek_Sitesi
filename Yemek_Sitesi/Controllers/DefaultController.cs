using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemek_Sitesi.Models;
namespace Yemek_Sitesi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        yemek_tarifiEntities1 db = new yemek_tarifiEntities1();
        public ActionResult Index()
        {
            var degerler = db.Yemekler.ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
     
    }
}