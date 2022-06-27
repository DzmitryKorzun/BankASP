using BankSystemASP.Domain.AuxiliaryModel;
using BankSystemASP.Domain.Entity;
using BankSystemASP.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Service.Interfaces
{
    public interface IExchangeRatesService
    {
        public Task<BaseResponse<List<ExchangeRates>>> GetSelectedExchangeRates(int iDBranhc, int day, int mounth, int year);
        public Task<BaseResponse<List<ExchangeRates>>> GetExchangeRatesInAllBranches(int idCurrency);
        public Task<BaseResponse<List<CoursePresentationTableModel>>> CoursePresentationTableModelCreator();
        public Task<BaseResponse<List<CoursePresentationTableModel>>> CoursePresentationTableModelCreator(int idBranch);
        public Task<BaseResponse<ExchangeRates>> GetExchangeRatesByNumberOfBranch(int idBranch, int idCurrency);
    }
}
