using AutoMapper;
using EkoFaktoring.Entity.Concrete;
using EkoFaktoring.Entity.Dtos;

namespace EkoFaktoring.Business.AutoMapper.Profiles
{
    public class CvBasvuruProfile : Profile
    {
        public CvBasvuruProfile()
        {
            CreateMap<CvBasvuru,CvBasvuruAddDto>();
            CreateMap<CvBasvuru, CvBasvuruUpdateDto>();
            CreateMap<CvBasvuruAddDto, CvBasvuru>();
            CreateMap<CvBasvuruUpdateDto, CvBasvuru>();
        }
    }
}