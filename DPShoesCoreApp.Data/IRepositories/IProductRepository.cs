using DPShoesCoreApp.Data.Entities;
using DPShoesCoreApp.Infrastructure.Interfaces;

namespace DPShoesCoreApp.Data.IRepositories
{
    public interface IProductRepository : IRepository<Product, int>
    {
    }
}
