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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext dbContext;
        public CustomerRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            return dbContext.Customers;
        }

        public Customer GetByEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> Select() => await dbContext.Customers.ToListAsync();

        async Task IBaseRepository<Customer>.Create(Customer entity)
        {
            dbContext.Add(entity);

            await dbContext.SaveChangesAsync();
        }

        Task<List<Customer>> IBaseRepository<Customer>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
