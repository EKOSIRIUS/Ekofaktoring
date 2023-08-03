using EkoFaktoring.Shared.Entities.Abstract;

namespace EkoFaktoring.Entity.Concrete
{
    public class DenetimRaporlari : EntityBase, IEntity
    {
        public byte[] Dosya { get; set; }
        public string DosyaAdi { get; set; }
        public string DosyaUzantisi { get; set; }
    }
}