﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WM.Core.Entities;

namespace WM.Core.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        // any custome  
        Task<List<Product>> GetProductsAsync();
    }
}
