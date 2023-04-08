using System;
using System.Threading.Tasks;
using Automarket.DAL.Interfaces;
using Automarket.Domain.Entity;
using Automarket.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Automarket.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var respnse = await _carService.GetCars();
            if (respnse.StatusCode == Domain.Enum.StatusCode.ok)
            {
                return View(respnse.Data);
            }

            return View(respnse.Data);
        }
    }
}