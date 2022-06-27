using BankSystemASP.DAL.Interfaces;
using BankSystemASP.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.DAL.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly ApplicationDbContext dbContext;
        public CurrencyRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task Create(Currency entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Currency entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Currency> GetAll()
        {
            return dbContext.Currencies;
        }

        public IQueryable<Currency> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetNameCurrencyById(int id)
        {
            var result = await dbContext.Currencies.FirstAsync(x => x.IdCurrency == id);
            return result.Name;
        }

        public async Task<List<Currency>> Select(string request)
        {
            return await dbContext.Currencies.FromSqlRaw(request).ToListAsync();
        }
    }
}
