

namespace MangaAPI.Application.DTOs.Manga
{
    public record CreateMangaDto
    {
        public string Title { get; init; }
        public string Description { get; init; }
        public string Author { get; init; }
        public string Genre { get; init; }
        public string CoverImage { get; init; }
    }
}
