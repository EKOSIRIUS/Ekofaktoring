using EkoFaktoring.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EkoFactoring.Data.Concrete.EntityFramework.Mapping
{
    public class DenetimRaporlariMap : IEntityTypeConfiguration<DenetimRaporlari>
    {
        public void Configure(EntityTypeBuilder<DenetimRaporlari> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Dosya).IsRequired();
            builder.Property(x => x.DosyaAdi).IsRequired();
            builder.Property(x => x.DosyaUzantisi).IsRequired();
        }
    }
}