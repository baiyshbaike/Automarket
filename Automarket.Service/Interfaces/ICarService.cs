using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Automarket.Domain.Entity;
using Automarket.Domain.Response;
using Automarket.Domain.ViewModels.Car;

namespace Automarket.Service.Interfaces
{
    public interface ICarService
    {
        Task<IBaseRespons<IEnumerable<Car>>> GetCars();
        Task<IBaseRespons<Car>> GetCar(int id);
        Task<BaseResponse<CarViewModel>> Create(CarViewModel carViewModel);
        Task<IBaseRespons<bool>> Delete(int id);
        Task<IBaseRespons<Car>> GetByName(string name);
        Task<IBaseRespons<Car>> Edit(int id, CarViewModel carViewModel);
    }
}