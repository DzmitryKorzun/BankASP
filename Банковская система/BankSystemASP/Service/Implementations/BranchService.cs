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
using BankSystemASP.Domain.AuxiliaryModel;

namespace BankSystemASP.Service.Implementations
{
    public class BranchService : IBranchServise
    {
        private readonly IBranchRepository branchRepository;
        private readonly IAddressRepository addressRepository;
        private readonly ICityRepository cityRepository;
        private readonly IRegionRepository regionRepository;

        public BranchService(IBranchRepository userRepository, IAddressRepository addressRepository,
            ICityRepository cityRepository, IRegionRepository regionRepository)
        {
            this.branchRepository = userRepository;
            this.addressRepository = addressRepository;
            this.cityRepository = cityRepository;
            this.regionRepository = regionRepository;
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

        public async Task<IBaseResponse<IEnumerable<BranchessAddress>>> GetBranchesWithAdress()
        {
            List<BranchessAddress> branchessAddresses = new List<BranchessAddress>();
            var baseResponse = new BaseResponse<IEnumerable<BranchessAddress>>();

            try
            {
                var branches = await branchRepository.SelectWithAddress();
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
                return new BaseResponse<IEnumerable<BranchessAddress>>()
                {
                    Description = $"[GetAllBranch] : {ex.Message}"
                };
            }
        }
    }
}
