using FoodAPI.Models;
using FoodAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService service;

        public FoodController(IFoodService service)
        {
            this.service = service;
        }
        [HttpGet("Foods")]
        public async Task<IActionResult> GetFoods()
        {
            var request = await service.GetFoods();
            return Ok(request);
        }
        [HttpGet("Food/{id}")]
        public async Task<IActionResult> GetFood(Guid id)
        {
            var request = await service.GetFood(id);
            return Ok(request);
        }
        [HttpPost("CreateFood")]
        public async Task<IActionResult> CreateFood(Food newFood)
        {
            var request = await service.CreateFood(newFood);
            return Ok(request);
        }
        [HttpPut("EditFood")]
        public async Task<IActionResult> UpdateFood(Food food)
        {
            var request = await service.UpdateFood(food);
            return Ok(request);
        }
        [HttpDelete("DeleteFood/{id}")]
        public ActionResult DeleteFood(Guid id)
        {
            var request = service.DeleteFood(id);
            return Ok(request);
        }
    }
}
