//using BankSystemASP.DAL.Interfaces;
//using BankSystemASP.Domain.Entity;
//using BankSystemASP.Domain.Response;
//using BankSystemASP.Service.Interfaces;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Text;
//using System.Threading.Tasks;

//namespace BankSystemASP.Service.Implementations
//{
//    public class AccountService : IAccountService
//    {
//        private readonly IBaseRepository<User> _userRepository;
//        private readonly ILogger<AccountService> _logger;

//        public AccountService(IBaseRepository<User> userRepository,
//            ILogger<AccountService> logger)
//        {
//            _userRepository = userRepository;
//            _logger = logger;
//        }
//        public async Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model)
//        {
            
//        }

//        public async Task<BaseResponse<ClaimsIdentity>> Register(User model)
//        {
//            try
//            {
//                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Name == model.Name);
//                if (user != null)
//                {
//                    return new BaseResponse<ClaimsIdentity>()
//                    {
//                        Description = "Пользователь с таким логином уже есть"
//                    };
//                }

//                user = new User()
//                {
//                    Name = model.Name,
//                    UserRole = Role.User,
//                    Password = HashPasswordHelper.HashPassowrd(model.Password),
//                };

//                await _userRepository.Create(user);
//                var result = Authenticate(user);

//                return new BaseResponse<ClaimsIdentity>()
//                {
//                    Data = result,
//                    Description = "Объект добавился",
//                    StatusCode = StatusCode.OK
//                };
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex, $"[Register]: {ex.Message}");
//                return new BaseResponse<ClaimsIdentity>()
//                {
//                    Description = ex.Message,
//                    StatusCode = StatusCode.InternalServerError
//                };
//            }
//        }
//    }
//}
