using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Core.Models.NedenFaktoring
{
    public class SikcaSorulanSorular : BaseEntity
    {
        public string Soru { get; set; }
        public string Cevap { get; set; }
    }
}
