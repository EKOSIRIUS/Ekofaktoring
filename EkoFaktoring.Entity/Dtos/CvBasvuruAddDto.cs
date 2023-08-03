using EkoFaktoring.Shared.Entities.Abstract;

namespace EkoFaktoring.Entity.Dtos
{
    public class CvBasvuruAddDto : DtoGetBase
    {
        public string AdSoyad { get; set; }
        public byte[] Dosya { get; set; }
        public string DosyaAdi { get; set; }
        public string DosyaUzantisi { get; set; }
    }
}