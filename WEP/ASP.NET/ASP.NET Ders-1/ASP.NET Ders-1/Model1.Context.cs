﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP.NET_Ders_1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SinemaCTX : DbContext
    {
        public SinemaCTX()
            : base("name=SinemaCTX")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<Salon> Salon { get; set; }
        public virtual DbSet<Yayin> Yayin { get; set; }
        public virtual DbSet<Yayin_Isimli> Yayin_Isimli { get; set; }
    
        public virtual int SP_FilmKaydet(ObjectParameter iD, string filmAdi, string filmKisaBilgi, string filmFragmanLink)
        {
            var filmAdiParameter = filmAdi != null ?
                new ObjectParameter("FilmAdi", filmAdi) :
                new ObjectParameter("FilmAdi", typeof(string));
    
            var filmKisaBilgiParameter = filmKisaBilgi != null ?
                new ObjectParameter("FilmKisaBilgi", filmKisaBilgi) :
                new ObjectParameter("FilmKisaBilgi", typeof(string));
    
            var filmFragmanLinkParameter = filmFragmanLink != null ?
                new ObjectParameter("FilmFragmanLink", filmFragmanLink) :
                new ObjectParameter("FilmFragmanLink", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_FilmKaydet", iD, filmAdiParameter, filmKisaBilgiParameter, filmFragmanLinkParameter);
        }
    }
}