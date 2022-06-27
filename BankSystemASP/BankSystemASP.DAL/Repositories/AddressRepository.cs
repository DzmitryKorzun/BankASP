using BankSystemASP.DAL.Interfaces;
using BankSystemASP.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BankSystemASP.DAL.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ApplicationDbContext dbContext;
        public AddressRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task Create(Addrees entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Addrees entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Addrees> GetAdressById(int id)
        {
            var result = await dbContext.Addrees.FirstAsync(x => x.idAddress == id);
            result.city = await dbContext.Cities.FirstAsync(x => x.idCity == result.idCity);
            result.city.region = await dbContext.Regions.FirstAsync(x => x.IdRegion == result.city.idRegion);
            return result;
        }

        public IEnumerable<Addrees> GetAll()
        {
            return dbContext.Addrees;
        }

        public Task<List<Addrees>> Select(string respnse)
        {
            throw new NotImplementedException();
        }

        IQueryable<Addrees> IBaseRepository<Addrees>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
