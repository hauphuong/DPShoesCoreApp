using DPShoesCoreApp.Data.Entities;
using DPShoesCoreApp.Infrastructure.Interfaces;

namespace DPShoesCoreApp.Data.IRepositories
{
    public interface IBlogRepository : IRepository<Blog, int>
    {
    }
}
