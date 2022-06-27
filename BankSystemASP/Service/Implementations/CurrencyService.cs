using BankSystemASP.DAL.Interfaces;
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
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository currencyRepository;
        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            this.currencyRepository = currencyRepository;
        }

        public async Task<BaseResponse<List<Currency>>> GetAllCurrency()
        {
            var response = new BaseResponse<List<Currency>>();            

            try
            {
                var result = currencyRepository.GetAll();
                response.Data = result.ToList();
                response.Status = Domain.Enum.StatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Status = Domain.Enum.StatusCode.InternalServerError;
                response.Description = ex.Message;
                return response;
            }

            
        }

        public async Task<BaseResponse<string>> GetNameCurrencyById(int id)
        {
            var baseresponse = new BaseResponse<string>();
            var result = await currencyRepository.GetNameCurrencyById(id);
            baseresponse.Data = result;
            return baseresponse;
        }
    }
}
