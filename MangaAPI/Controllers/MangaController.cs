using AutoMapper;
using MangaAPI.Application.DTOs.Manga;
using MangaAPI.Application.Services;
using MangaAPI.Domain.Entities;
using MangaAPI.Persistance.Contexts;
using MangaAPI.Persistance.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace MangaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MangaController : ControllerBase
    {

        private readonly IMangaService _mangaService;
 
        public MangaController(IMangaService mangaService )
        {
            _mangaService = mangaService;
            
             
        }
        [HttpGet("GetAllManga")]
        public IActionResult GetAllManga() 
        {
            var responce = _mangaService.GetAllManga();
            return Ok(responce.Result);
        }
        [HttpGet("GetManga/{id:Guid}")]
        public  IActionResult GetManga([FromRoute] Guid id)
        {
            var response = _mangaService.GetManga(id);
            return Ok(response.Result);
        }
        [HttpPost("CreateManga")]
        public IActionResult CreateManga([FromBody] CreateMangaDto createMangaDto) 
        {
            _mangaService.CreateManga(createMangaDto);
            return Ok();
        }
        [HttpPut("UpdateManga")]
        public IActionResult UpdateManga([FromBody] UpdateMangaDto updateMangaDto)
        {
            _mangaService.UpdateManga(updateMangaDto);
            return Ok();
        }
        


    }
}
