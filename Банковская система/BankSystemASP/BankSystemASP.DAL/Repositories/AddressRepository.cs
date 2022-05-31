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

        public async Task<IQueryable<Addrees>> GetAdressById(int id)
        {
            return dbContext.Addrees.FromSqlRaw("SELECT * FROM banksys.Addrees where idAddress == {0}", id);
        }

        public IEnumerable<Addrees> GetAll()
        {
            return dbContext.Addrees;
        }

        public Task<List<Addrees>> Select()
        {
            throw new NotImplementedException();
        }

        IQueryable<Addrees> IBaseRepository<Addrees>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
