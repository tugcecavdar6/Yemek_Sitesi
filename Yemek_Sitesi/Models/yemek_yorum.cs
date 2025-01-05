using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yemek_Sitesi.Models
{
    public class yemek_yorum
    {
        public IEnumerable<Yemekler> deger1 { get; set; }
        public IEnumerable<Yorumlar> deger2 { get; set; }
        public IEnumerable<Yemekler> deger3 { get; set; }
    }
}