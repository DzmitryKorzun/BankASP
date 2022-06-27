using BankSystemASP.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.DAL.Interfaces
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        Customer GetByEmail(string Email);
        Task<Dictionary<int, string>> GetEmailsUsers();
        Task<List<СustomerBankAccounts>> GetСustomerBankAccounts();
        Task<BankAccount> GetBankAccountNumber(int id);
        Task<Customer> GetOwnerBank(int id);
    }
}
