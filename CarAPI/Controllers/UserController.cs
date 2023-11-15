using CarAPI.Entities;
using CarAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }
        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var request = await service.GetUsers();
            return Ok(request);
        }
        [HttpGet("GetUser/{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var request = await service.GetUser(id);
            return Ok(request);
        }
        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser(User newUser)
        {
            var request = await service.CreateUser(newUser);
            return Ok(request);
        }
        [HttpPut("EditUser/{id}")]
        public async Task<IActionResult> EditUser(User user)
        {
            var request = await service.EditUser(user);
            return Ok(request);
        }
        [HttpDelete("DeleteUser/{id}")]
        public ActionResult DeleteUser(Guid id)
        {
            var request = service.DeleteUser(id);
            return Ok(request);
        }
    }
}
