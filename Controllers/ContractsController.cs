using Microsoft.AspNetCore.Mvc;

namespace EnterpriseSearchService.Controllers
{
    [ApiController]
    [Route("api/contracts")]
    public class ContractsController : ControllerBase
    {
        private readonly IContractSearchService _searchService;

        public ContractsController(IContractSearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpPost("search")]
        public async Task<IActionResult> Search([FromBody] ContractSearchRequest request)
        {
            var result = await _searchService.SearchAsync(request);

            return Ok(new
            {
                TotalCount = result.Total,
                Data = result.Documents
            });
        }
    }
}
