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
    public class ExchangeRatesRepository : IExchangeRatesRepository
    {
        private readonly ApplicationDbContext dbContext;
        public ExchangeRatesRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task Create(ExchangeRates entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ExchangeRates entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExchangeRates> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<ExchangeRates> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ExchangeRates> GetExchangeRatesByNumberOfBranch(int namberBranch, int idCurrency)
        {
            var idBranch = await dbContext.Branches.FirstAsync(x=>x.Namber == namberBranch);
            var result = await dbContext.ExchangeRates.FirstAsync(x => x.IdBranch == idBranch.IdBranch && x.IdCurrency == idCurrency);
            return result;
        }

        public async Task<List<ExchangeRates>> Select(string request)
        {
            return dbContext.ExchangeRates.FromSqlRaw(request).ToList();
        }
    }
}
