using Nest;
using EnterpriseSearchService.Models;
using EnterpriseSearchService.DTOs;

namespace EnterpriseSearchService.Services
{
    public class ContractSearchService : IContractSearchService
    {
        private readonly IElasticClient _elasticClient;

        public ContractSearchService(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public async Task<ISearchResponse<ContractDocument>> SearchAsync(ContractSearchRequest request)
        {
            return await _elasticClient.SearchAsync<ContractDocument>(s => s
                .From((request.Page - 1) * request.PageSize)
                .Size(request.PageSize)
                .Query(q => q.Bool(b => b.Must(
                    m => m.Term(t => t.CountryCode, request.CountryCode),
                    m => m.Term(t => t.CurrencyCode, request.CurrencyCode),
                    m => m.Term(t => t.IsActive, true)
                )))
            );
        }
    }
}
