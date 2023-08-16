using DPWorld.API.DTO;

namespace DPWorld.API.Extensions
{
    public static class StreamReaderCustomExtensions
    {
        public static FinantialDto CsvToJsonConverter(this StreamReader financialData)
        {
            financialData.ReadLine();
            var csvLine = financialData.ReadLine()!.Split(',');
            var newReseit = new FinantialDto
            {
                BusinessUnit = csvLine[0],
                ReceiptMethodID = csvLine[1],
                ReceiptDate = csvLine[6],
                RemittanceBankAccount = csvLine[3],
                AccountingDate = csvLine[7],
                ConversionDate = csvLine[8],
                Currency = csvLine[9],
                ConversionRateType = csvLine[10],
                ConversionRate = csvLine[11],
                CustomerName = csvLine[12],
                CustomerAccountNumber = csvLine[13],
                CustomerSiteNumber = csvLine[14],
                Comments = csvLine[17],



            };
            while (!financialData.EndOfStream)
            {

                //var line = await st.ReadToEndAsync();

                var transactions = new TransactionDto

                {
                    RemittanceBank = csvLine[2],
                    ReceiptNumber = csvLine[4],
                    ReceiptAmount = csvLine[5],
                    InvoiceNumberReference = csvLine[15],
                    InvoiceAmount = csvLine[16],
                };


                newReseit.Transactions.Add(transactions);
                csvLine = financialData.ReadLine()!.Split(",");
            }
            return newReseit;
        }
    }
}
