﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yemek_Sitesi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class yemek_tarifiEntities1 : DbContext
    {
        public yemek_tarifiEntities1()
            : base("name=yemek_tarifiEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<gununyemegi> gununyemegi { get; set; }
        public virtual DbSet<Hakkimizda> Hakkimizda { get; set; }
        public virtual DbSet<iletisim> iletisim { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tarifler> Tarifler { get; set; }
        public virtual DbSet<Yemekler> Yemekler { get; set; }
        public virtual DbSet<Yonetici> Yonetici { get; set; }
        public virtual DbSet<Yorumlar> Yorumlar { get; set; }
    }
}
