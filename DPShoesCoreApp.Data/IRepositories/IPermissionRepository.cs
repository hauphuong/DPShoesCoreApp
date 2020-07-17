using DPShoesCoreApp.Data.Entities;
using DPShoesCoreApp.Infrastructure.Interfaces;

namespace DPShoesCoreApp.Data.IRepositories
{
    public interface IPermissionRepository : IRepository<Permission, int>
    {
    }
}
