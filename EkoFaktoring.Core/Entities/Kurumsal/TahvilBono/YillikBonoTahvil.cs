using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Core.Models.Kurumsal.TahvilBono
{
    public class YillikBonoTahvil : BaseEntity
    {
        public int Yil { get; set; }
        public double BonoTahvilTutari { get; set; }
        public double ItfaEdilmisTutar { get; set; }
    }
}
