﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter.icrud
{
    public interface ICrud <T> 
    {
        Task<IEnumerable<T>>  GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T t);
        Task UpdateAsync(T t);
        Task DeleteAsync(int id);
    }
}
