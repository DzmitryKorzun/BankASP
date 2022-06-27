using BankSystemASP.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.DAL.Interfaces
{
    public interface ICurrencyRepository: IBaseRepository<Currency>
    {
        public Task<string> GetNameCurrencyById(int id);
    }
}
