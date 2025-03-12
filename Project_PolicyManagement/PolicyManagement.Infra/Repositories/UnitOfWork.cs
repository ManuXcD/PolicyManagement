using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicyManagement.Core;
using PolicyManagement.Infra.Interfaces;

namespace PolicyManagement.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PolicyManagementDBContext _context;
        private IRepository<Policy> _policies;

        public UnitOfWork(PolicyManagementDBContext context)
        {
            _context = context;
        }

        public IRepository<Policy> Policies => _policies ??= new Repository<Policy>(_context);

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
