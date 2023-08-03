using EkoFaktoring.Entity.Concrete;
using EkoFaktoring.Entity.Dtos;
using EkoFaktoring.Shared.Utilities.Results.Abstract;

namespace EkoFaktoring.Business.Abstract
{
    public interface ICvBasvuruService
    {
        Task<IDataResult<CvBasvuru>> Get(int cvBasvuruId);
        Task<IDataResult<IList<CvBasvuru>>> GetAll();
        Task<IResult> Add(CvBasvuruAddDto cvBasvuruAddDto,string createdByName);
        Task<IResult> Update(CvBasvuruUpdateDto cvBasvuruUpdateDto,string modifiedByName);
        Task<IResult> Delete(int cvBasvuruId, string modifiedByName);
        Task<IResult> HardDelete(int cvBasvuruId);
    }
}