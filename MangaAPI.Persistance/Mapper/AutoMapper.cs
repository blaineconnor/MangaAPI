using AutoMapper;
using MangaAPI.Application.DTOs.Chapter;
using MangaAPI.Application.DTOs.Manga;
using MangaAPI.Application.DTOs.User;
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
            CreateMap<DeleteMangaDto,Manga>().ReverseMap();
            CreateMap<CreateChapterDto,Chapter>().ReverseMap();
            CreateMap<UpdateChapterDto, Chapter>().ReverseMap();
            CreateMap<DeleteChapterDto, Chapter>().ReverseMap();
            CreateMap<GetAllChapterDto, Chapter>().ReverseMap();
            CreateMap<GetChapterDto, Chapter>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}
