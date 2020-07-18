using DPShoesCoreApp.Data.Entities;
using DPShoesCoreApp.Data.IRepositories;

namespace DPShoesCoreApp.Data.EF.Repositories
{
    public class ProductRepository : EFRepository<Product, int>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}