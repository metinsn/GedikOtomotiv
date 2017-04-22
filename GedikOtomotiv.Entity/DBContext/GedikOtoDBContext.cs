namespace GedikOtomotiv.Entity.DBContext
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class GedikOtoDBContext : DbContext
    {
        public GedikOtoDBContext()
            : base("name=GedikOtoDB")
        {
        }
        public virtual DbSet<Kira> Kira { get; set; }
        public virtual DbSet<AracMarka> AracMarka { get; set; }
        public virtual DbSet<AracModel> AracModel { get; set; }
        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
    }
}