using AutoMapper;
using MangaAPI.Application.DTOs.Chapter;
using MangaAPI.Application.DTOs.Manga;
using MangaAPI.Application.Services;
using MangaAPI.Domain.Entities;
using MangaAPI.Infrastructure.Helpers;
using MangaAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaAPI.Persistance.Services
{
    public class ChapterService :IChapterService 
    {
        private readonly MangaAPIDbContext _context;
        private readonly IMapper _mapper;

        public ChapterService(MangaAPIDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task CreateChapter(CreateChapterDto createChapterDto)
        {
            var chapter = _mapper.Map<Chapter>(createChapterDto);
            BaseEntityCreator.Create(chapter);
            await _context.AddAsync(chapter);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateChapter(UpdateChapterDto updateChapterDto)
        {

            var chapter = _context.Chapters.Where(chapter => chapter.Id == updateChapterDto.Id).FirstOrDefault();
            _mapper.Map(updateChapterDto, chapter);
            _context.Update(chapter);
            await _context.SaveChangesAsync();

        }
        public async Task<GetChapterDto> GetChapter(Guid id)
        {
            var chapter = _context.Chapters.Where(chapter => chapter.Id == id).FirstOrDefault();
            var mappedChapter = _mapper.Map<GetChapterDto>(chapter);
            return mappedChapter;
        }
        public async Task<List<GetAllChapterDto>> GetAllChapter()
        {
            var chapter = await _context.Chapters.ToListAsync();
            var mappedChapter = _mapper.Map<List<GetAllChapterDto>>(chapter);
            return mappedChapter;
        }
        public async Task DeleteChapter(Guid id)
        {
            var chapter = _context.Chapters.Where(chapter => chapter.Id == id).FirstOrDefault();
            _context.Remove(chapter);
            await _context.SaveChangesAsync();
        }

       
    }
}
