using EkoFaktoring.Core.Models;
using EkoFaktoring.Core.Models.Duyurular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Core.Entities.Duyurular
{
    public class Kategori : BaseEntity
    {
        public List<Duyuru> Duyurular { get; set; }
    }
}
