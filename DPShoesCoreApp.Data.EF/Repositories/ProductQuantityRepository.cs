﻿using DPShoesCoreApp.Data.Entities;
using DPShoesCoreApp.Data.IRepositories;

namespace DPShoesCoreApp.Data.EF.Repositories
{
    public class ProductQuantityRepository : EFRepository<ProductQuantity, int>, IProductQuantityRepository
    {
        public ProductQuantityRepository(AppDbContext context) : base(context)
        {
        }
    }
}