namespace DPWorld.API.DTO
{
    public class TransactionDto
    {

        public string RemittanceBank { get; set; } = string.Empty;
        public string ReceiptNumber { get; set; } = string.Empty;
        public string ReceiptAmount { get; set; } = string.Empty;
        public string InvoiceNumberReference { get; set; } = string.Empty;
        public string InvoiceAmount { get; set; } = string.Empty;

    }

}
