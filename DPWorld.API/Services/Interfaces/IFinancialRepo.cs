using DPWorld.API.DTO;

namespace DPWorld.API.Services.Interfaces
{
    public interface IFinancialRepo
    {
        public FinantialDto getFinancialInfo(StreamReader financialData);


    }
}
