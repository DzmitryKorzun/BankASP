using BankSystemASP.Domain.AuxiliaryModel;
using BankSystemASP.Domain.Entity;
using BankSystemASP.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Service.Interfaces
{
    public interface ICustomerService
    {
        Task<IBaseResponse<IEnumerable<Customer>>> GetAllCustomers();
        Task<IBaseResponse<Dictionary<int, string>>> GetUsersEmails();
        Task<IBaseResponse<List<AdminBankAccountView>>> GetAllBankAccountView(int userId);
        Task<BaseResponse<ClaimsIdentity>> Registration(Customer customer);
        Task<BaseResponse<ClaimsIdentity>> Login(Customer model);
        Task<IBaseResponse<bool>> СheckingThePossibilityOfTranslation(string CardNumberSender, string InputCVV, string ValidatySender, string CardNumberRecipient, string ValidatyRecipient);
    }
}
