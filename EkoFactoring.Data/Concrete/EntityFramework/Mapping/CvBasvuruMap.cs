using EkoFaktoring.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EkoFactoring.Data.Concrete.EntityFramework.Mapping
{
    public class CvBasvuruMap : IEntityTypeConfiguration<CvBasvuru>
    {
        public void Configure(EntityTypeBuilder<CvBasvuru> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AdSoyad).IsRequired();
            builder.Property(x => x.Dosya).IsRequired();
            builder.Property(x => x.DosyaUzantisi).IsRequired();
        }
    }
}