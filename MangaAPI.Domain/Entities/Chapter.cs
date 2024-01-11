using MangaAPI.Domain.Common;


namespace MangaAPI.Domain.Entities
{
    public class Chapter : AuditableEntity
    {
        public int? ChapterNumber { get; set; }
        public string? Title { get; set; }
        public DateTime? UploadDate { get; set; }
        public int? Pages { get; set; }
        public string? FilePath { get; set; }
        public Manga? Manga { get; set; }
        public Guid MangaId { get; set; }
    }
}
