using Microsoft.AspNetCore.Mvc;
using PolicyManagement.Core;
using PolicyManagement.Services.Interfaces;

namespace PolicyManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        private readonly IPolicyService _policyService;

        public PolicyController(IPolicyService policyService)
        {
            _policyService = policyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPolicies()
        {
            var policies = await _policyService.GetAllPoliciesAsync();
            return Ok(policies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPolicyById(int id)
        {
            var policy = await _policyService.GetPolicyByIdAsync(id);
            if (policy == null)
            {
                return NotFound();
            }
            return Ok(policy);
        }

        [HttpPost]
        public async Task<IActionResult> AddPolicy([FromBody] Policy policy)
        {
            await _policyService.AddPolicyAsync(policy);
            return CreatedAtAction(nameof(GetPolicyById), new { id = policy.Id }, policy);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePolicy(int id, [FromBody] Policy policy)
        {
            if (id != policy.Id)
            {
                return BadRequest();
            }
            await _policyService.UpdatePolicyAsync(policy);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePolicy(int id)
        {
            await _policyService.DeletePolicyAsync(id);
            return NoContent();
        }
    }
}
