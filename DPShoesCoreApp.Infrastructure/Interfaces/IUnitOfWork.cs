using System;

namespace DPShoesCoreApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        void Commit();
    }
}
