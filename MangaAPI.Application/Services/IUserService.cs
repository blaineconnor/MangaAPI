using MangaAPI.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaAPI.Application.Services
{
    public interface IUserService
    {
        Task CreateUser(UserDto userDto);
        Task UpdateUser(UserDto userDto);
        Task DeleteUser(Guid id);
        Task<List<UserDto>> GetAllUsers();
        Task<UserDto> GetUserById(Guid id);
    }
}
