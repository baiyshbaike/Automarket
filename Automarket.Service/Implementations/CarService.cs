using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Automarket.DAL.Interfaces;
using Automarket.Domain.Entity;
using Automarket.Domain.Enum;
using Automarket.Domain.Response;
using Automarket.Service.Interfaces;

namespace Automarket.Service.Implementations
{
    public class CarService :ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public async Task<IBaseRespons<IEnumerable<Car>>> GetCars()
        {
            var baseResponse = new BaseResponse<IEnumerable<Car>>();
            try
            {
                var cars = await _carRepository.select();
                if (cars.Count == 0)
                {
                    baseResponse.Description = "Найдено 0 элементов";
                    baseResponse.StatusCode = StatusCode.ok;
                    return baseResponse;
                }

                baseResponse.Data = cars;
                baseResponse.StatusCode = StatusCode.ok;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Car>>()
                {
                    Description = $"[GetCars] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerEror
                };
            }
        }
    }
}