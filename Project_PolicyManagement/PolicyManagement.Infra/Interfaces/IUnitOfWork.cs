using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicyManagement.Core;

namespace PolicyManagement.Infra.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Policy> Policies { get; }
        Task SaveChangesAsync();
    }
}
