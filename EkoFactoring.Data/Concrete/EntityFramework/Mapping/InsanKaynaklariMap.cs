using EkoFaktoring.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EkoFactoring.Data.Concrete.EntityFramework.Mapping
{
    public class InsanKaynaklariMap : IEntityTypeConfiguration<InsanKaynaklari>
    {
        public void Configure(EntityTypeBuilder<InsanKaynaklari> builder)
        {
            builder.HasKey(x => x.Id); // PrimaryKey
            builder.Property(x => x.Id).ValueGeneratedOnAdd(); // Identity
            builder.Property(x => x.Baslik).HasMaxLength(50);
            builder.Property(x => x.Baslik).IsRequired();
            builder.HasData(new InsanKaynaklari()
            {
                Baslik = "Test",
                Aciklama = "Bir sayfanın düzenine bakıldığında okunabilir içeriğin okuyucunun dikkatini dağıtacağı uzun zamandır bilinen bir gerçektir. Lorem Ipsum'u kullanmanın amacı, 'İçerik burada, içerik burada' seçeneğinin aksine, aşağı yukarı normal bir harf dağılımına sahip olması ve okunabilir bir İngilizce gibi görünmesidir. Birçok masaüstü yayıncılık paketi ve web sayfası düzenleyicisi artık varsayılan model metni olarak Lorem Ipsum'u kullanıyor ve 'lorem ipsum' için yapılan bir arama, henüz emekleme aşamasında olan birçok web sitesini ortaya çıkaracaktır. Yıllar içinde, bazen kazara, bazen kasıtlı olarak (mizah zerresi vb.) çeşitli versiyonlar geliştirilmiştir."
                
            });
        }
    }
}