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

        public async Task<IBaseResponse<IEnumerable<Customer>>> GetAllUsers()
        {
            var baseResponse = new BaseResponse<IEnumerable<Customer>>();
            try
            {
                var customers = await customerRepository.GetById(1);
                if (customers.Count == 0)
                {
                    baseResponse.Description = "Нет пользователей :-(";
                    baseResponse.Status = StatusCode.UsersNotFound;
                    return baseResponse;
                }
                baseResponse.Data = customers;
                baseResponse.Status = StatusCode.OK;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Customer>>()
                {
                    Description = $"[GetAllUser] : {ex.Message}"
                };                
            }
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
                customer.HASHED_PASSWORD = HashPasswordHelper.HashPassword(customer.HASHED_PASSWORD + salt);
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
               // _logger.LogError(ex, $"[Register]: {ex.Message}");
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

                if (customer.HASHED_PASSWORD != HashPasswordHelper.HashPassword(model.HASHED_PASSWORD + model.Salt))
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
              //  _logger.LogError(ex, $"[Login]: {ex.Message}");
                return new BaseResponse<ClaimsIdentity>()
                {
                    Description = ex.Message,
                    Status = StatusCode.InternalServerError
                };
            }
        }
    }
}
