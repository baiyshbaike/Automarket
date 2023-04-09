using System;
using System.Threading.Tasks;
using Automarket.DAL.Interfaces;
using Automarket.Domain.Entity;
using Automarket.Domain.ViewModels.Car;
using Automarket.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
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
            if (respnse.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(respnse.Data);
            }

            return RedirectToAction("Error");
        }
        [HttpGet]
        public async Task<IActionResult> GetCar(int id)
        {
            var response = await _carService.GetCar(id);
            if (response.StatusCode==Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return RedirectToAction("Error");
        }
        [HttpGet]
        public async Task<IActionResult> GetByName(string name)
        {
            var response = await _carService.GetByName(name);
            if (response.StatusCode==Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return RedirectToAction("Error");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _carService.Delete(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return RedirectToAction("GetCars");
            }

            return RedirectToAction("Error");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Save(int id)
        {
            if (id==0)
            {
                return View();
            }

            var response = await _carService.GetCar(id);
            if (response.StatusCode==Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return RedirectToAction("Error");
        }

        [HttpPost]
        public async Task<IActionResult> Save(CarViewModel carViewModel)
        {
            if (ModelState.IsValid)
            {
                if (carViewModel.Id==0)
                {
                    await _carService.Create(carViewModel);
                }
                else
                {
                    await _carService.Edit(carViewModel.Id, carViewModel);
                }
            }

            return RedirectToAction("GetCars");
        }
        public IActionResult Error()
        {
            throw new NotImplementedException();
        }
    }
}