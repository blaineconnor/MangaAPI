using MangaAPI.Application.DTOs.Manga;
using MangaAPI.Domain.Entities;
using MangaAPI.Persistance.Contexts;
using MangaAPI.Infrastructure.Helpers;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using MangaAPI.Persistance.Migrations;

namespace MangaAPI.Application.Services
{
    public class MangaService : IMangaService
    {

        private readonly MangaAPIDbContext _context;
        private readonly IMapper _mapper;

        public MangaService(MangaAPIDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task CreateManga(CreateMangaDto createMangaDto)
        {
                Manga manga = _mapper.Map<Manga>(createMangaDto);
                BaseEntityCreator.Create(manga);
                await _context.Mangas.AddAsync(manga);
                await _context.SaveChangesAsync();  
        }
        public async Task UpdateManga(UpdateMangaDto updateMangaDto)
        {
            
                var manga = _context.Mangas.Where(x=>x.Id ==  updateMangaDto.Id).FirstOrDefault();

                if (manga == null)
                {
                    Console.WriteLine("Güncellenmesi istenen manga bulunamadı.");
                    return;
                }
                _mapper.Map(updateMangaDto, manga);
                _context.Update(manga);
                await _context.SaveChangesAsync();
           
        }
        public async Task<GetMangaDto> GetManga(Guid id)
        {
            var manga = _context.Mangas.Where(manga => manga.Id == id).FirstOrDefault();
            var mappedManga = _mapper.Map<GetMangaDto>(manga);
            return mappedManga;
        }
        public async Task<List<GetAllMangaDto>> GetAllManga()
        {
            var manga = await _context.Mangas.ToList();
            var mappedManga = _mapper.Map<GetAllMangaDto>(manga);
            return mappedManga;
        }
    }
}
