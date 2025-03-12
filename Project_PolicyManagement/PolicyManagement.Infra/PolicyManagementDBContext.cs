using Microsoft.EntityFrameworkCore;
using PolicyManagement.Core;

namespace PolicyManagement.Infra
{
    public class PolicyManagementDBContext : DbContext
    {
        public PolicyManagementDBContext(DbContextOptions<PolicyManagementDBContext> options): base(options)
        {
            
        }

        public DbSet<Policy>? Policies { get; set; }
    }
}
