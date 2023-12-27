using MangaAPI.Application.DTOs.Chapter;
using MangaAPI.Application.DTOs.Manga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaAPI.Application.Services
{
    public interface IChapterService
    {
        Task CreateChapter(CreateChapterDto createChapterDto);
        Task UpdateChapter(UpdateChapterDto updateChapterDto);
        Task<GetChapterDto> GetChapter(Guid id);
        Task<List<GetAllChapterDto>> GetAllChapter();
        Task DeleteChapter(Guid id);
    }
}
