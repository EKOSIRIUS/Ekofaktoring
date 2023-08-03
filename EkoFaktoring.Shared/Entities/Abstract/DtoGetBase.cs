using EkoFaktoring.Shared.Utilities.Results.ComplexTypes;

namespace EkoFaktoring.Shared.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
    }
}