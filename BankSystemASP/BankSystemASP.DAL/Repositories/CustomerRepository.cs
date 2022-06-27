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

        public IQueryable<Customer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Dictionary<int, string>> GetEmailsUsers()
        {
            var result = dbContext.Customers;
            var myDictionary = new Dictionary<int, string>();
            foreach (var user in result)
            {
                myDictionary.Add(user.IdCustomer, user.Email);
            }
            return myDictionary;
        }

        public Task<BankAccount> GetOwnerBank(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<BankAccount> GetStringNumber(int id)
        {
            return await dbContext.BankAccounts.FirstAsync(x=>x.IdBankAccount==id);
        }

        public Task<List<СustomerBankAccounts>> GetСustomerBankAccounts()
        {
            return dbContext.CustomerBankAccounts.ToListAsync();
        }

        public async Task<List<Customer>> Select(string respnse) => await dbContext.Customers.ToListAsync();

        async Task IBaseRepository<Customer>.Create(Customer entity)
        {
            dbContext.Add(entity);

            await dbContext.SaveChangesAsync();
        }

        async Task<BankAccount> ICustomerRepository.GetBankAccountNumber(int id)
        {
            return await dbContext.BankAccounts.FirstAsync(x => x.IdBankAccount == id);
        }

        Task<Customer> ICustomerRepository.GetOwnerBank(int id)
        {
            throw new NotImplementedException();
        }
    }
}
