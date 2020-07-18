using DPShoesCoreApp.Data.Entities;
using DPShoesCoreApp.Data.IRepositories;

namespace DPShoesCoreApp.Data.EF.Repositories
{
    public class ContactRepository : EFRepository<Contact, string>, IContactRepository
    {
        public ContactRepository(AppDbContext context) : base(context)
        {
        }
    }
}