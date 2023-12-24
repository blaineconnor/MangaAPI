

using MangaAPI.Application.DTOs.Manga;

namespace MangaAPI.Application.Services
{
    public interface IMangaService
    {
        Task CreateManga(CreateMangaDto createMangaDto);
    }
}
