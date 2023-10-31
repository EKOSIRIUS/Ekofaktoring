using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Core.Models.Iletisim
{
    public class Iletisim : BaseEntity
    {
        public string AdiSoyadi { get; set; }
        public string Email { get; set; }
        public string TelefonNumarasi { get; set; }
        public string Icerik { get; set; }
    }
}
