using MangaAPI.Application.DTOs.Manga;
using MangaAPI.Domain.Entities;
using MangaAPI.Persistance.Contexts;
using MangaAPI.Infrastructure.Helpers;
using AutoMapper;

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
            try
            {
                Manga manga = _mapper.Map<Manga>(createMangaDto);
                BaseEntityCreator.Create(manga);
                await _context.Mangas.AddAsync(manga);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
