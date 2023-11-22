using FoodAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService service;
        public CategoryController(ICategoryService service)
        {
            this.service = service;
        }
        [HttpGet("Categorys")]
        public async Task<IActionResult> GetCategorys()
        {
            var request = await service.GetCategorys();
            return Ok(request);
        }
        [HttpGet("Category/{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var request = await service.GetCategory(id);
            return Ok(request);
        }
        [HttpGet("Category/Foods/{id}")]
        public async Task<IActionResult> GetFoodsCategory(int id)
        {
            var request = await service.GetFoodCategorys(id);
            return Ok(request);
        }
    }
}
