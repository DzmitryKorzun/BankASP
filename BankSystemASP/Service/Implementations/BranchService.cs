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
                var branches = await branchRepository.Select("");
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

        public async Task<IBaseResponse<List<int>>> GetAllNumbersBranchers()
        {
            var baseResponse = new BaseResponse<List<int>>();

            try
            {
                string requste = "select Namber from branches";
                var branches = await branchRepository.SelectAllBranchNumbers(requste);
                baseResponse.Data = branches;
                baseResponse.Status = StatusCode.OK;
                baseResponse.Description = "All Ok!";
                return baseResponse;
            }
            catch (Exception ex)
            {
                baseResponse.Status = StatusCode.InternalServerError;
                baseResponse.Description = "Very bad!";
                return baseResponse;
            }
        }

        public async Task<IBaseResponse<IEnumerable<string>>> GetArrayOfBranchesStringsWithAddressAndNumber()
        {
            try
            {
                List<string> adressLines = new List<string>();
                var BranchesWithAdress = GetBranchesWithAdress();
                foreach (var branches in BranchesWithAdress.Result.Data)
                {
                    adressLines.Add($"Номер: {branches.Namber}  Адрес: {branches.AddreesRegion} область, {branches.AddreesCity}, {branches.StreetType} {branches.AddreesStreet}, дом {branches.Building}");
                }
                var response = new BaseResponse<IEnumerable<string>>();
                response.Data = adressLines;
                response.Status = StatusCode.OK;
                return response;
            }
            catch 
            {
                var response = new BaseResponse<IEnumerable<string>>();
                response.Data = null;
                response.Status = StatusCode.InternalServerError;
                return response;
            }
        }

        public async Task<IBaseResponse<Branch>> GetBranchByNumber(int number)
        {
            BaseResponse<Branch> response = new BaseResponse<Branch>();
            var result = branchRepository.GetBranchByNumber(number);
            response.Data = await result;
            return response;
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
                    baseResponse.Description = "Branch not found :-(";
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

        public async Task<IBaseResponse<Branch>> GetIdByNumber(int number)
        {
            string request = $"select * from Branches where Namber = {number}";
            try
            {
                var result = branchRepository.GetIdByNumber(request);
                var response = new BaseResponse<Branch>();
                response.Data = await result;
                response.Status = StatusCode.OK;
                response.Description = "Request completed successfully";
                return response;
            }
            catch(Exception ex)
            {
                var errorResponse = new BaseResponse<Branch>();
                errorResponse.Data = null;
                errorResponse.Status = StatusCode.InternalServerError;
                errorResponse.Description = $"Request failed :-(\n {ex.Message}";
                return errorResponse;
            }
        }

        public async Task<IBaseResponse<string>> GetStringAddress(Branch branch)
        {
            BaseResponse<string> response = new BaseResponse<string>();
            response.Data = $"{branch.Namber} - {branch.Addrees.city.region.name} область, {branch.Addrees.city.name}, {branch.Addrees.street} д. {branch.Addrees.building}";
            return response;
        }
    }
}
