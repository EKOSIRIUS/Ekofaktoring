using AutoMapper;
using EkoFactoring.Data.Abstract;
using EkoFaktoring.Business.Abstract;
using EkoFaktoring.Entity.Concrete;
using EkoFaktoring.Entity.Dtos;
using EkoFaktoring.Shared.Utilities.Results.Abstract;
using EkoFaktoring.Shared.Utilities.Results.ComplexTypes;
using EkoFaktoring.Shared.Utilities.Results.Concrete;

namespace EkoFaktoring.Business.Concrete
{
    public class CvBasvuruManager : ICvBasvuruService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CvBasvuruManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IResult> Add(CvBasvuruAddDto cvBasvuruAddDto, string createdByName)
        {
            var cvbasvuru = _mapper.Map<CvBasvuru>(cvBasvuruAddDto);
            await _unitOfWork.CvBasvuru.AddAsync(cvbasvuru);
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Basvuru başarılıyla eklenmiştir.");
        }
        public async Task<IResult> Delete(int cvBasvuruId, string modifiedByName)
        {
            var cvbasvuru = await _unitOfWork.CvBasvuru.GetAsync(x => x.Id == cvBasvuruId);
            if (cvbasvuru != null)
            {
                cvbasvuru.IsDeleted = true;
                cvbasvuru.ModifiedDate = DateTime.Now;
                cvbasvuru.ModifiedByName = modifiedByName;
                await _unitOfWork.CvBasvuru.UpdateAsync(cvbasvuru);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Basvuru başarılıyla silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Silinecek başvuru bulunamadı.");
        }
        public async Task<IDataResult<CvBasvuru>> Get(int cvBasvuruId)
        {
            var cvbasvuru = await _unitOfWork.CvBasvuru.GetAsync(x => x.Id == cvBasvuruId);
            if (cvbasvuru != null)
            {
                return new DataResult<CvBasvuru>(ResultStatus.Success,cvbasvuru);
            }
            return new DataResult<CvBasvuru>(ResultStatus.Error, "Basvuru bulunamadı", null);
        }
        public async Task<IDataResult<IList<CvBasvuru>>> GetAll()
        {
            var cvbasvuru = await _unitOfWork.CvBasvuru.GetAllAsync();
            if (cvbasvuru.Count > 0)
            {
                return new DataResult<IList<CvBasvuru>>(ResultStatus.Success, cvbasvuru);
            }
            return new DataResult<IList<CvBasvuru>>(ResultStatus.Error, "Basvuru bulunamadı", null);
        }
        public async Task<IResult> HardDelete(int cvBasvuruId)
        {
            var cvbasvuru = await _unitOfWork.CvBasvuru.GetAsync(x => x.Id == cvBasvuruId);
            if (cvbasvuru != null)
            {
                await _unitOfWork.CvBasvuru.DeleteAsync(cvbasvuru);
                return new Result(ResultStatus.Success, "Basvuru başarılıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Silinecek başvuru bulunamadı.");
        }
        public async Task<IResult> Update(CvBasvuruUpdateDto cvBasvuruUpdateDto, string modifiedByName)
        {
            var cvbasvuru = _mapper.Map<CvBasvuru>(cvBasvuruUpdateDto);
            cvbasvuru.ModifiedByName = modifiedByName;
            await _unitOfWork.CvBasvuru.UpdateAsync(cvbasvuru);
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Cv başarıyla güncellendi.");
        }
    }
}