using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaAPI.Application.DTOs.Manga
{
    public class DeleteMangaDto
    {
        public Guid Id { get; set; }
        public string? Title { get; init; }
        public string? Description { get; init; }
        public string? Author { get; init; }
        public string? Genre { get; init; }
        public string? CoverImage { get; init; }
    }
}
