using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Automarket.DAL.Interfaces;
using Automarket.Domain.Entity;
using Automarket.Domain.Enum;
using Automarket.Domain.Response;
using Automarket.Domain.ViewModels.Car;
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

        public async Task<BaseResponse<CarViewModel>> Create(CarViewModel carViewModel)
        {
            var baseResponse = new BaseResponse<CarViewModel>();
            try
            {
                var car = new Car()
                {
                    Description = carViewModel.Description,
                    DateCreate = DateTime.Now,
                    Speed = carViewModel.Speed,
                    Model = carViewModel.Model,
                    Price = carViewModel.Price,
                    Name = carViewModel.Name,
                    TypeCar = (TypeCar)Convert.ToInt32(carViewModel.TypeCar)
                };
                await _carRepository.Create(car);
            }
            catch (Exception e)
            {
                return new BaseResponse<CarViewModel>()
                {
                    Description = $"[Create] : {e.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
            return baseResponse;
        }
        public async Task<IBaseRespons<bool>> Delete(int id)
        {
            var baseResponse = new BaseResponse<bool>();
            try
            {
                var car = await _carRepository.Get(id);
                if (car == null)
                {
                    baseResponse.Description = "User not found";
                    baseResponse.StatusCode = StatusCode.UserNotFound;
                    return baseResponse;
                }

                await _carRepository.Delete(car);
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[Delete] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
        public async Task<IBaseRespons<Car>> GetCar(int id)
        {
            var baseResponse = new BaseResponse<Car>();
            try
            {
                var car =await _carRepository.Get(id);
                if (car == null)
                {
                    baseResponse.Description = "user not fount";
                    baseResponse.StatusCode = StatusCode.UserNotFound;
                    return baseResponse;
                }

                baseResponse.Data = car;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<Car>()
                {
                    Description = $"[GetCar] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
        public async Task<IBaseRespons<Car>> GetByName(string name)
        {
            var baseResponse = new BaseResponse<Car>();
            try
            {
                var car =await _carRepository.GetByName(name);
                if (car == null)
                {
                    baseResponse.Description = "user not fount";
                    baseResponse.StatusCode = StatusCode.UserNotFound;
                    return baseResponse;
                }

                baseResponse.Data = car;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<Car>()
                {
                    Description = $"[GetByName] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
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
                    baseResponse.StatusCode = StatusCode.OK;
                    return baseResponse;
                }

                baseResponse.Data = cars;
                baseResponse.StatusCode = StatusCode.OK;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Car>>()
                {
                    Description = $"[GetCars] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}