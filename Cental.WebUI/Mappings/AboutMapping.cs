using AutoMapper;
using Cental.DataTransferObjectLayer.Dtos.AboutDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ToListAboutDto>().ReverseMap();
            
        }
    }
}
