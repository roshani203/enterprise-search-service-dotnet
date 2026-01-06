using Nest;
using EnterpriseSearchService.Models;
using EnterpriseSearchService.DTOs;

namespace EnterpriseSearchService.Services
{
    public interface IContractSearchService
    {
        Task<ISearchResponse<ContractDocument>> SearchAsync(ContractSearchRequest request);
    }
}
