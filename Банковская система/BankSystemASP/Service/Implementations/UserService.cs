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

namespace Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<IBaseResponse<IEnumerable<User>>> GetAllUsers()
        {
            var baseResponse = new BaseResponse<IEnumerable<User>>();
            try
            {
                var users = await userRepository.Select();
                if (users.Count == 0)
                {
                    baseResponse.Description = "Нет пользователей :-(";
                    baseResponse.Status = StatusCode.UsersNotFound;
                    return baseResponse;
                }
                baseResponse.Data = users;
                baseResponse.Status = StatusCode.OK;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<User>>()
                {
                    Description = $"[GetAllUser] : {ex.Message}"
                };
                
            }
        }
    }
}
