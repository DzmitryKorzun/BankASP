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

        public async Task<List<City>> GetCitiesByRegion(string region)
        {
            return await dbContext.Cities.Where(x=> x.region.name == region).ToListAsync();
        }

        public Task<List<City>> Select(string respnse)
        {
            throw new NotImplementedException();
        }
    }
}
