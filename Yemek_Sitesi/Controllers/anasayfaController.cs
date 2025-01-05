using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemek_Sitesi.Models;
namespace Yemek_Sitesi.Controllers
{

    public class anasayfaController : Controller
    {
        // GET: anasayfa
        yemek_tarifiEntities1 db = new yemek_tarifiEntities1();
        yemek_yorum by = new yemek_yorum();
        public ActionResult Index()
        {
            Yemekler yemekler = new Yemekler();
            //var yemek = db.Yemekler.ToList();
            by.deger1 = db.Yemekler.ToList();
            by.deger3 = db.Yemekler.OrderByDescending(x => x.Yemekid).Take(3);
            return View(by);
        }
        
        public ActionResult AnasayfaDetay(int id)
        {

            by.deger1 = db.Yemekler.Where(x => x.Yemekid == id).ToList();
            by.deger2 = db.Yorumlar.Where(x => x.Yemekid == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            db.Yorumlar.Add(y);
            db.SaveChanges();

            return PartialView();

        }
    }
}