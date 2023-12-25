using AutoMapper;
using MangaAPI.Application.DTOs.Manga;
using MangaAPI.Domain.Entities;

namespace MangaAPI.Persistance.Mapper
{
    public class AutoMapper : Profile
    {
       public AutoMapper() {
            CreateMap<CreateMangaDto, Manga>().ReverseMap();
            CreateMap<UpdateMangaDto, Manga>().ReverseMap();
            CreateMap<GetMangaDto, Manga>().ReverseMap();
            CreateMap<GetAllMangaDto, Manga>().ReverseMap();  
       }
    }
}
