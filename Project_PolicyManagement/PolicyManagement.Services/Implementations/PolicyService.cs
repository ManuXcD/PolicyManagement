using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicyManagement.Core;
using PolicyManagement.Infra.Interfaces;
using PolicyManagement.Services.Interfaces;

namespace PolicyManagement.Services.Implementations
{
    public class PolicyService : IPolicyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PolicyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Policy>> GetAllPoliciesAsync()
        {
            return await _unitOfWork.Policies.GetAllAsync();
            
        }

        public async Task<Policy> GetPolicyByIdAsync(int id)
        {
            return await _unitOfWork.Policies.GetByIdAsync(id);
        }

        public async Task AddPolicyAsync(Policy policy)
        {
            await _unitOfWork.Policies.AddAsync(policy);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdatePolicyAsync(Policy policy)
        {
            await _unitOfWork.Policies.UpdateAsync(policy);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeletePolicyAsync(int id)
        {
            await _unitOfWork.Policies.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
