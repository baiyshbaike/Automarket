using System;
using System.Threading.Tasks;
using Automarket.DAL.Interfaces;
using Automarket.Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Automarket.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var response = await _carRepository.select();
            var response1 = await _carRepository.GetByName("BMW X5");
            var response2 = await _carRepository.Get(4);
            var car = new Car()
            {
                Name = "VAZ 2114",
                Model = "Vaz",
                Speed = 140,
                Price = 150000,
                Description = "ВАЗ",
                DateCreate = DateTime.Now
            };
            await _carRepository.Create(car);
            await _carRepository.Delete(car);
            return View(response);
        }
    }
}