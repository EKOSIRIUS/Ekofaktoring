using EkoFaktoring.Shared.Entities.Abstract;

namespace EkoFaktoring.Entity.Concrete
{
    public class Hakkimizda : EntityBase, IEntity
    {
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}