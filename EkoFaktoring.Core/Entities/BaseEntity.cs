using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Core.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created_Date { get; set; } = DateTime.Now;
        public DateTime Updated_Date { get; set; } = DateTime.Now;
    }
}
