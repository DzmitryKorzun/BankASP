using BankSystemASP.DAL.Interfaces;
using BankSystemASP.Domain.Entity;
using BankSystemASP.Domain.Response;
using BankSystemASP.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystemASP.Domain.Enum;
using BankSystemASP.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using BankSystemASP.Domain.Helpers;
using BankSystemASP.Domain.AuxiliaryModel;

namespace Service.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public Task<IBaseResponse<IEnumerable<Customer>>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        private ClaimsIdentity Authenticate(Customer customer)
        {
            var claimsIdentity = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultRoleClaimType, customer.IdRole.ToString()),
                new Claim(ClaimsIdentity.DefaultNameClaimType, customer.Email)
            };
            return new ClaimsIdentity(claimsIdentity,"AppCookie",ClaimsIdentity.DefaultRoleClaimType, ClaimsIdentity.DefaultNameClaimType);
        }
        
        public async Task<BaseResponse<ClaimsIdentity>> Registration(Customer customer)
        {
            try
            {
                var user = customerRepository.GetAll().FirstOrDefault(x => x.Email == customer.Email);
                if (user != null)
                {
                    return new BaseResponse<ClaimsIdentity>()
                    {
                        Description = "Пользователь с таким логином уже есть",
                    };
                }
                customer.IdRole = 1;
                var salt = SaltGenerator.GenerateSalt();
                customer.Salt = salt;
                customer.HASHED_PASSWORD = HashPasswordHelper.HashPassword(customer.HASHED_PASSWORD) + salt;
                await customerRepository.Create(customer);
                var result = Authenticate(customer);

                return new BaseResponse<ClaimsIdentity>()
                {
                    Data = result,
                    Description = "Объект добавился",
                    Status = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<ClaimsIdentity>()
                {
                    Description = ex.Message,
                    Status = StatusCode.InternalServerError
                };


            }

        }

        public async Task<BaseResponse<ClaimsIdentity>> Login(Customer model)
        {
            try
            {
                var customer = customerRepository.GetAll().FirstOrDefault(x => x.Email == model.Email);
                if (customer == null)
                {
                    return new BaseResponse<ClaimsIdentity>()
                    {
                        Description = "Пользователь не найден"
                    };
                }
                var hashPassLogin = HashPasswordHelper.HashPassword(model.HASHED_PASSWORD) + customer.Salt;
                if (customer.HASHED_PASSWORD != hashPassLogin)
                {
                    return new BaseResponse<ClaimsIdentity>()
                    {
                        Description = "Неверный пароль"
                    };
                }
                var result = Authenticate(customer);
                return new BaseResponse<ClaimsIdentity>()
                {
                    Data = result,
                    Status = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<ClaimsIdentity>()
                {
                    Description = ex.Message,
                    Status = StatusCode.InternalServerError
                };
            }
        }

        public Task<IBaseResponse<bool>> СheckingThePossibilityOfTranslation(string CardNumberSender, string InputCVV, string ValidatySender, string CardNumberRecipient, string ValidatyRecipient)
        {
            throw new NotImplementedException();
        }

        public async Task<IBaseResponse<Dictionary<int, string>>> GetUsersEmails()
        {
            var baseResponse = new BaseResponse<Dictionary<int, string>>();
            var result = customerRepository.GetEmailsUsers();
            baseResponse.Data = await result;
            return baseResponse;
        }

        public async Task<IBaseResponse<List<AdminBankAccountView>>> GetAllBankAccountView(int userId)
        {
            var baseResponse = new BaseResponse<List<AdminBankAccountView>>();
            var customerBankAccounts = await customerRepository.GetСustomerBankAccounts();
            var items = customerBankAccounts.Where(x=>x.IdCustomer==userId).ToList();
            var adminBank = new List<AdminBankAccountView>();
            var BankAccount = await customerRepository.GetBankAccountNumber(userId);
            foreach (var item in items)
            {                
              //  adminBank.Add(new AdminBankAccountView() { BankAccountNamber = BankAccount.CardNumber,  Owner = BankAccount. });
            }
            baseResponse.Data = adminBank;
            return baseResponse;
        }
    }
}
