using DPShoesCoreApp.Data.Entities;
using DPShoesCoreApp.Data.IRepositories;

namespace DPShoesCoreApp.Data.EF.Repositories
{
    public class TagRepository : EFRepository<Tag, string>, ITagRepository
    {
        public TagRepository(AppDbContext context) : base(context)
        {
        }
    }
}