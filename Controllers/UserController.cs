using DAUinfo.Model;
using DAUinfo.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAUinfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _User;

        public UserController(IUser users)
        {
            _User = users;
        }
        [HttpPost("addUser")]
        public async Task<IActionResult> CreateUser(User user)
        {
            try
            {
                await _User.AddUser(user);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("getallUser")]
        public async Task<List<User>> GetAllUser()
        {
            try
            {
                var userlist = await _User.GetAllUser();
                return userlist;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
