using AutoMapper;
using MangaAPI.Application.DTOs.Manga;
using MangaAPI.Application.DTOs.User;
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
    public class UserService : IUserService
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly MangaAPIDbContext _context;

        public UserService(IUserService userService, IMapper mapper, MangaAPIDbContext context)
        {
            _userService = userService;
            _mapper = mapper;
            _context = context;
        }

        public async Task CreateUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            BaseEntityCreator.Create(user);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();


        }

        public async Task DeleteUser(Guid id)
        {
            var user = _context.Mangas.Where(user => user.Id == id).FirstOrDefault();
            _context.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<UserDto>> GetAllUsers()
        {
            var user = await _context.Mangas.ToListAsync();
            var mappedUser = _mapper.Map<List<UserDto>>(user);
            return mappedUser;
        }

        public async Task<UserDto> GetUserById(Guid id)
        {
            var user = _context.Mangas.Where(user => user.Id == id).FirstOrDefault();
            var mappedUser = _mapper.Map<UserDto>(user);
            return mappedUser;
        }

        public async Task UpdateUser(UserDto userDto)
        {
            var user = _context.Mangas.Where(x => x.Id == userDto.Id).FirstOrDefault();
            _mapper.Map(userDto, user);
            _context.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
