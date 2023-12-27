using MangaAPI.Application.DTOs.Manga;
using MangaAPI.Application.DTOs.User;
using MangaAPI.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace MangaAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;

        }
        #region user controller
        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            var responce = _userService.GetAllUsers();
            return Ok(responce.Result);
        }
        [HttpGet("GetUserById/{id:Guid}")]
        public IActionResult GetUserById([FromRoute] Guid id)
        {
            var response = _userService.GetUserById(id);
            return Ok(response.Result);
        }
        [HttpPost("CreateUser")]
        public IActionResult CreateUser([FromBody] UserDto userDto)
        {
            _userService.CreateUser(userDto);
            return Ok();
        }
        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser([FromBody] UserDto userDto)
        {
            _userService.UpdateUser(userDto);
            return Ok();
        }
        [HttpDelete("DeleteUser/{id:Guid}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }
        #endregion
    }
}
