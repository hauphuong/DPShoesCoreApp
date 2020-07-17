using DPShoesCoreApp.Data.Entities;
using DPShoesCoreApp.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace DPShoesCoreApp.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}
