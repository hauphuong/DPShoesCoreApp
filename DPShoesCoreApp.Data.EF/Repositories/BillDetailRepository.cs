using DPShoesCoreApp.Data.Entities;
using DPShoesCoreApp.Data.IRepositories;

namespace DPShoesCoreApp.Data.EF.Repositories
{
    public class BillDetailRepository : EFRepository<BillDetail, int>, IBillDetailRepository
    {
        public BillDetailRepository(AppDbContext context) : base(context)
        {
        }
    }
}