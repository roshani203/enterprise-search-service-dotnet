namespace EnterpriseSearchService.Models
{
    public class ContractDocument
    {
        public string ContractId { get; set; }
        public string CountryCode { get; set; }
        public string CurrencyCode { get; set; }
        public string ProductTier { get; set; }
        public bool IsActive { get; set; }
    }
}
