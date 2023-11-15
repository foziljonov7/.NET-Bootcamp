using CarAPI.Entities;
using CarAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService service;

        public CarController(ICarService service)
        {
            this.service = service;
        }
        [HttpGet("GetCars")]
        public async Task<IActionResult> GetCras()
        {
            var request = await service.GetCars();
            return Ok(request);
        }
        [HttpGet("GetCar/{id}")]
        public async Task<IActionResult> GetCar(Guid id)
        {
            var request = await service.GetCar(id);
            return Ok(request);
        }
        [HttpPost("CreateCar")]
        public async Task<IActionResult> CreateCar(Car newCar)
        {
            var request = await service.CreateCar(newCar);
            return Ok(request);
        }
        [HttpPut("EditCar/{id}")]
        public async Task<IActionResult> EditCar(Car car)
        {
            var request = await service.EditCar(car);
            return Ok(request);
        }
        [HttpDelete("DeleteCar/{id}")]  
        public ActionResult DeleteCar(Guid id)
        {
            var request = service.DeleteCar(id);
            return Ok(request);
        }
    } 
}
