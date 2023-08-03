using EkoFaktoring.Shared.Entities.Abstract;

namespace EkoFaktoring.Entity.Concrete
{
    public class CvBasvuru : EntityBase, IEntity
    {
        public string AdSoyad { get; set; }
        public byte[] Dosya { get; set; }
        public string DosyaAdi { get; set; }
        public string DosyaUzantisi { get; set; }
    }
}