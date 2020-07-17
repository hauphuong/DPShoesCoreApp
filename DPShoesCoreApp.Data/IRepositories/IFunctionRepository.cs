using DPShoesCoreApp.Data.Entities;
using DPShoesCoreApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPShoesCoreApp.Data.IRepositories
{
    public interface IFunctionRepository : IRepository<Function, string>
    {
    }
}
