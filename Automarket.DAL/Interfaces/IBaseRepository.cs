﻿using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Automarket.Domain.Entity;

namespace Automarket.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<bool> Create(T entity);
        Task<Car> Get(int id);
        Task<List<Car>> select();
        Task<bool> Delete(T entity);
    }
}