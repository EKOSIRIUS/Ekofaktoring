using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Core.Models.Kurumsal.TahvilBono
{
    public class TahvilBono : BaseEntity
    {
        public string AraciKurum { get; set; }
        public string Turu { get; set; }
        public DateTime IhracTarihi { get; set; }
        public DateTime TahvilBonoVadesi { get; set; }
        public int VadeGunSayisi { get; set; }
        public double TahvilBonoTutari { get; set; }
        public string Durumu { get; set; }
    }
}
