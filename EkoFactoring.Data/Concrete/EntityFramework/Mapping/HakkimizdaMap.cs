using EkoFaktoring.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EkoFactoring.Data.Concrete.EntityFramework.Mapping
{
    public class HakkimizdaMap : IEntityTypeConfiguration<Hakkimizda>
    {
        public void Configure(EntityTypeBuilder<Hakkimizda> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Baslik).IsRequired();
            builder.HasData(new Hakkimizda()
            {
                Baslik = "Hakkımızda",
                Aciklama = "Bir sayfanın düzenine bakıldığında okunabilir içeriğin okuyucunun dikkatini dağıtacağı uzun zamandır bilinen bir gerçektir. Lorem Ipsum'u kullanmanın amacı, 'İçerik burada, içerik burada' seçeneğinin aksine, aşağı yukarı normal bir harf dağılımına sahip olması ve okunabilir bir İngilizce gibi görünmesidir. Birçok masaüstü yayıncılık paketi ve web sayfası düzenleyicisi artık varsayılan model metni olarak Lorem Ipsum'u kullanıyor ve 'lorem ipsum' için yapılan bir arama, henüz emekleme aşamasında olan birçok web sitesini ortaya çıkaracaktır. Yıllar içinde, bazen kazara, bazen kasıtlı olarak (mizah zerresi vb.) çeşitli versiyonlar geliştirilmiştir.",

            });
        }
    }
}