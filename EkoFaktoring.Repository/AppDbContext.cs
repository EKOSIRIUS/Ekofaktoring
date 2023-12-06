using EkoFaktoring.Core.Entities.Duyurular;
using EkoFaktoring.Core.Models.Duyurular;
using EkoFaktoring.Core.Models.Iletisim;
using EkoFaktoring.Core.Models.Kurumsal;
using EkoFaktoring.Core.Models.Kurumsal.DenetimRaporu;
using EkoFaktoring.Core.Models.Kurumsal.TahvilBono;
using EkoFaktoring.Core.Models.NedenFaktoring;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Duyuru> Duyurular { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<BagimsizDenetimRaporu> DenetimRaporu { get; set; }
        public DbSet<BagimsizDerecelendirmeRaporu> DerecelendirmeRaporu { get; set; }
        public DbSet<TahvilBono> TahvilBono { get; set; }
        public DbSet<YillikBonoTahvil> YillikBonoTahvil { get; set; }
        public DbSet<FirmaProfil> FirmaProfil { get; set; }
        public DbSet<InsanKaynaklariPolitikasi> InsanKaynaklariPolitikasi { get; set; }
        public DbSet<FaktoringNedir> FaktoringNedir { get; set; }
        public DbSet<GerekliBelgeler> GerekliBelgeler { get; set; }
        public DbSet<SikcaSorulanSorular> SikcaSorulanSorular { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
