using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Core.Models.NedenFaktoring
{
    public class GerekliBelgeler : BaseEntity
    {
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public string DosyaYolu { get; set; }
    }
}
