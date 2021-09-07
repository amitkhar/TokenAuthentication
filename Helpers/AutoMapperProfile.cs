using AutoMapper;
using System.Text;
using TokenAuthentication.Models;
using TokenAuthentication.DTOs;

namespace TokenAuthentication.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<TblBook, BookListDto>();
            CreateMap<LoginDTO, TblUser>();
            CreateMap<RegisterDTO, TblUser>()
           .ForMember(dest => dest.Password, opt => opt.MapFrom(src => Encoding.Unicode.GetBytes( src.Password)));
        }
    }
}