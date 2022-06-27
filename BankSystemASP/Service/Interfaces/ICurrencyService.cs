using BankSystemASP.Domain.Entity;
using BankSystemASP.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Service.Interfaces
{
    public interface ICurrencyService
    {
        public Task<BaseResponse<List<Currency>>> GetAllCurrency();
        public Task<BaseResponse<string>> GetNameCurrencyById(int id);
    }
}
