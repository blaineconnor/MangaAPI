using MangaAPI.Application.DTOs.Manga;
using MangaAPI.Application.Services;
using MangaAPI.Persistance.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace MangaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MangaController : ControllerBase
    {

        private readonly IMangaService _mangaService;
        private readonly MangaAPIDbContext _context;

        public MangaController(IMangaService mangaService, MangaAPIDbContext context)
        {
            _mangaService = mangaService;
            _context = context;
        }

        [HttpPost(Name = "CreateManga")]
        public IActionResult CreateManga([FromBody] CreateMangaDto createMangaDto) 
        {
            _mangaService.CreateManga(createMangaDto);
            return Ok();
        }

        [HttpGet("get/{mangaId}")]
        public async  Task<IActionResult> GetManga([FromRoute] Guid mangaId)
        {
            var response = await _context.Mangas.FindAsync(mangaId);

            return Ok(response);

        }

    }
}
