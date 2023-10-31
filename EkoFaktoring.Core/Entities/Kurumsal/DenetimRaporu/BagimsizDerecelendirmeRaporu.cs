using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Core.Models.Kurumsal.DenetimRaporu
{
    public class BagimsizDerecelendirmeRaporu : BaseEntity
    {
        public int Year { get; set; }
        public string RaporAdi { get; set; }
        public string RaporYolu { get; set; }
    }
}
