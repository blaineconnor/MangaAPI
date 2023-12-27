using MangaAPI.Application.DTOs.Chapter;
using MangaAPI.Application.DTOs.Manga;
using MangaAPI.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace MangaAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChapterController : ControllerBase
    {
        private readonly IChapterService _chapterService;

        public ChapterController(IChapterService chapterService)
        {
            _chapterService = chapterService;
        }

        [HttpGet("GetChapter/{id:Guid}")]
        public IActionResult GetChapter([FromRoute] Guid id)
        {
            var response = _chapterService.GetChapter(id);
            return Ok(response.Result);
        }
        [HttpGet("GetAllChapter")]
        public IActionResult GetAllChapter()
        {
            var responce = _chapterService.GetAllChapter();
            return Ok(responce.Result);
        }
        [HttpPost("CreateChapter")]
        public IActionResult CreateChapter([FromBody] CreateChapterDto createChapterDto)
        {
            _chapterService.CreateChapter(createChapterDto);
            return Ok();
        }
        [HttpPut("UpdateChapter")]
        public IActionResult UpdateChapter([FromBody] UpdateChapterDto updateChapterDto)
        {
            _chapterService.UpdateChapter(updateChapterDto);
            return Ok();
        }
        [HttpDelete("DeleteChapter/{id:Guid}")]
        public IActionResult DeleteChapter([FromRoute] Guid id)
        {
            _chapterService.DeleteChapter(id);
            return Ok();
        }

    }
}
