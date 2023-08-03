using EkoFactoring.Data.Concrete.EntityFramework.Mapping;
using EkoFaktoring.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EkoFactoring.Data.Concrete.EntityFramework.Contexts
{
    public class EkoFaktoringContext : DbContext
    {
        public DbSet<CvBasvuru> CvBasvuru { get; set; }
        public DbSet<DenetimRaporlari> DenetimRaporlari { get; set; }
        public DbSet<Hakkimizda> Hakkimizda { get; set; }
        public DbSet<InsanKaynaklari> InsanKaynaklari { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("",ServerVersion.AutoDetect(""));
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CvBasvuruMap());
            modelBuilder.ApplyConfiguration(new DenetimRaporlariMap());
            modelBuilder.ApplyConfiguration(new HakkimizdaMap());
            modelBuilder.ApplyConfiguration(new InsanKaynaklariMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}