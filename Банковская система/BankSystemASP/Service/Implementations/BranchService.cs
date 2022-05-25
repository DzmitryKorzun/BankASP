using BankSystemASP.DAL.Interfaces;
using BankSystemASP.Domain.Entity;
using BankSystemASP.Domain.Enum;
using BankSystemASP.Domain.Response;
using BankSystemASP.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Service.Implementations
{
    public class BranchService : IBranchServise
    {
        private readonly IBranchRepository branchRepository;

        public BranchService(IBranchRepository userRepository)
        {
            this.branchRepository = userRepository;
        }

        public async Task Create(Branch branch)
        {
            await branchRepository.Create(branch);
        }

        public async Task<IBaseResponse<IEnumerable<Branch>>> GetAllBranches()
        {
            var baseResponse = new BaseResponse<IEnumerable<Branch>>();
            try
            {
                var branches = await branchRepository.Select();
                if (branches.Count == 0)
                {
                    baseResponse.Description = "Нет отделов :-(";
                    baseResponse.Status = StatusCode.UsersNotFound;
                    return baseResponse;
                }
                baseResponse.Data = branches;
                baseResponse.Status = StatusCode.OK;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Branch>>()
                {
                    Description = $"[GetAllBranch] : {ex.Message}"
                };
            }

        }

        //async Task<IBaseResponse<Branch>> IBranchServise.Create(Branch branch)
        //{
        //     await branchRepository.Create(branch);             
        //}
    }
}
