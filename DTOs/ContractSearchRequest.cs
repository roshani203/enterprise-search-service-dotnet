namespace EnterpriseSearchService.DTOs
{
    public class ContractSearchRequest
    {
        public string CountryCode { get; set; }
        public string CurrencyCode { get; set; }

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
