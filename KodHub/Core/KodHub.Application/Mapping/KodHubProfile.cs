using AutoMapper;
using KodHub.Application.Dtos.CategoryDtos;
using KodHub.Domain.Entities;

namespace KodHub.Application.Mapping
{
    public class KodHubProfile : Profile
    {
        public KodHubProfile()
        {
            CreateMap<Category, AddCategoryDto>().ReverseMap();
            CreateMap<Category, ListCategoryDto>().ReverseMap();
        }
    }
}
