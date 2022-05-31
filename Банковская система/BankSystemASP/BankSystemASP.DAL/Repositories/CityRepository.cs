using BankSystemASP.DAL.Interfaces;
using BankSystemASP.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.DAL.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly ApplicationDbContext dbContext;
        public CityRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task Create(City entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(City entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetAll()
        {
            return dbContext.Cities;
        }

        public IQueryable<City> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<City>> Select()
        {
            throw new NotImplementedException();
        }
    }
}
