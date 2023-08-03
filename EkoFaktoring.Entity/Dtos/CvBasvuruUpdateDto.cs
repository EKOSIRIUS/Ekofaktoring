using EkoFaktoring.Shared.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace EkoFaktoring.Entity.Dtos
{
    public class CvBasvuruUpdateDto : DtoGetBase
    {
        public string AdSoyad { get; set; }
        [Required(ErrorMessage = "Dosya zorunludur.")]
        public byte[] Dosya { get; set; }
        public string DosyaAdi { get; set; }
        public string DosyaUzantisi { get; set; } 
    }
}