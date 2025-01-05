using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemek_Sitesi.Models;
namespace Yemek_Sitesi.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        yemek_tarifiEntities1 db = new yemek_tarifiEntities1();
        public ActionResult Index()
        {

           
            return View();
        }
      
        //[HttpGet]
        //public PartialViewResult iletisim_kur(int id)
        //{
        //    ViewBag.deger = id;
        //   return PartialView();
        //}
        [HttpPost]
        public PartialViewResult iletisim_kur(iletisim y)
        {
          db.iletisim.Add(y);
           db.SaveChanges();

           return PartialView();

        }
    }
    //public ActionResult Index(iletisim model)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        var body = new iletisim();
    //        body.AppendLine("İsim: " + model.AdSoyad);
    //        body.AppendLine("Mail Adresi: " + model.Mail);
    //        body.AppendLine("Konu: " + model.konu);
    //        body.AppendLine("Masaj: " + model.Mesaj);

    //        Gmail.SendMail(body.ToString());
    //        ViewBag.Success = true;
    //    }
    //    return View();

    //}
}