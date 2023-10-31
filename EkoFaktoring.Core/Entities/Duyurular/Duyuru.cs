using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Core.Models.Duyurular
{
    public class Duyuru : BaseEntity
    {
        public string GorselYolu { get; set; }
        public DateTime DuyuruTarihi { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
    }
}
