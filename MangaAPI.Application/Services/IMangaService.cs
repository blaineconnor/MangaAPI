using MangaAPI.Application.DTOs.Manga;

namespace MangaAPI.Application.Services
{
    public interface IMangaService
    {
        Task CreateManga(CreateMangaDto createMangaDto);
        Task UpdateManga(UpdateMangaDto updateMangaDto);
        Task<GetMangaDto> GetManga(Guid id);
        Task<List<GetAllMangaDto>> GetAllManga();
        Task DeleteManga (Guid id);
        
    }
}
