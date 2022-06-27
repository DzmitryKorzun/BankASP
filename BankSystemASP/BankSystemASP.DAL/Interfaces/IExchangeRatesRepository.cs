using BankSystemASP.Domain.Entity;
using System.Threading.Tasks;

namespace BankSystemASP.DAL.Interfaces
{
    public interface IExchangeRatesRepository:IBaseRepository<ExchangeRates>
    {
        public Task<ExchangeRates> GetExchangeRatesByNumberOfBranch(int idBranch, int idCurrency);
    }
}
