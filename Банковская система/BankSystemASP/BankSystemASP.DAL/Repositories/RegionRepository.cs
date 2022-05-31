using BankSystemASP.DAL.Interfaces;
using BankSystemASP.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.DAL.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly ApplicationDbContext dbContext;
        public RegionRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task Create(Region entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Region entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Region> GetAll()
        {
            return dbContext.Regions;
        }

        public IQueryable<Region> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Region>> Select()
        {
            throw new NotImplementedException();
        }
    }
}
