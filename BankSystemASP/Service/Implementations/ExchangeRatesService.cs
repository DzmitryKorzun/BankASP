using BankSystemASP.DAL.Interfaces;
using BankSystemASP.Domain.AuxiliaryModel;
using BankSystemASP.Domain.Entity;
using BankSystemASP.Domain.Response;
using BankSystemASP.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Service.Implementations
{
    public class ExchangeRatesService : IExchangeRatesService
    {
        IExchangeRatesRepository ratesRepository;
        public ExchangeRatesService(IExchangeRatesRepository ratesRepository)
        {
            this.ratesRepository = ratesRepository;
        }

        public Task<BaseResponse<List<CoursePresentationTableModel>>> CoursePresentationTableModelCreator()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<List<CoursePresentationTableModel>>> CoursePresentationTableModelCreator(int idBranch)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<ExchangeRates>> GetExchangeRatesByNumberOfBranch(int idBranch, int idCurrency)
        {
            BaseResponse<ExchangeRates> baseResponse = new BaseResponse<ExchangeRates>();
            var result = await ratesRepository.GetExchangeRatesByNumberOfBranch(idBranch, idCurrency);
            baseResponse.Data = result;
            return baseResponse;
        }

        public async Task<BaseResponse<List<ExchangeRates>>> GetExchangeRatesInAllBranches(int idCurrency)
        {
            string selectRequest = $"select * from ExchangeRates where {idCurrency} = IdCurrency";
            try
            {
                var result = ratesRepository.Select(selectRequest);
                var baseResponse = new BaseResponse<List<ExchangeRates>>();
                baseResponse.Data = await result;
                baseResponse.Status = Domain.Enum.StatusCode.OK;
                baseResponse.Description = "Fetch from table <Exchange Rates> successful";
                return baseResponse;
            }
            catch (Exception ex)
            {
                var errorResponse = new BaseResponse<List<ExchangeRates>>();
                errorResponse.Data = null;
                errorResponse.Status = Domain.Enum.StatusCode.InternalServerError;
                errorResponse.Description = $"Select error: + {ex.Message}";
                return errorResponse;
            }
        }

        public async Task<BaseResponse<List<ExchangeRates>>> GetSelectedExchangeRates(int IdBranhc, int day, int month, int year)
        {
            DateTime selectedDateTime = new DateTime(year, month, day);
            string selectRequest = $"select * from ExchangeRates where {IdBranhc} = IdBranch and \"{selectedDateTime:O}\" = Date";
            try
            {
                var result = ratesRepository.Select(selectRequest);
                var baseResponse = new BaseResponse<List<ExchangeRates>>();
                baseResponse.Data = await result;
                baseResponse.Status = Domain.Enum.StatusCode.OK;
                baseResponse.Description = "Fetch from table <Exchange Rates> successful";
                return baseResponse;
            }
            catch (Exception ex)
            {
                var errorResponse = new BaseResponse<List<ExchangeRates>>();
                errorResponse.Data = null;
                errorResponse.Status = Domain.Enum.StatusCode.InternalServerError;
                errorResponse.Description = $"Select error: + {ex.Message}";
                return errorResponse;
            }
        }
    }
}
