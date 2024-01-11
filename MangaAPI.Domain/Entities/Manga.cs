using MangaAPI.Domain.Common;


namespace MangaAPI.Domain.Entities
{
    public class Manga : AuditableEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
    }
}
