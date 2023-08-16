namespace DPWorld.API.DTO
{
    public class FinantialDto
    {
        public string BusinessUnit { get; set; } = string.Empty;
        public string ReceiptMethodID { get; set; } = string.Empty;
        public string RemittanceBankAccount { get; set; } = string.Empty;
        public string ReceiptDate { get; set; } = string.Empty;
        public string AccountingDate { get; set; } = string.Empty;
        public string ConversionDate { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string ConversionRateType { get; set; } = string.Empty;
        public string ConversionRate { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerAccountNumber { get; set; } = string.Empty;
        public string CustomerSiteNumber { get; set; } = string.Empty;
        public string Comments { get; set; } = string.Empty;

        public List<TransactionDto> Transactions { get; set; } = new List<TransactionDto>();
    }
}
