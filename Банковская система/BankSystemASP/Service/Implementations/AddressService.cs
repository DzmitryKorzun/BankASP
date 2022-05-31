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
    public class AddressService: IAddressService
    {
        private readonly IAddressRepository adressRepository;

        public AddressService(IAddressRepository adressRepository)
        {
            this.adressRepository = adressRepository;
        }

        public async Task<IBaseResponse<IEnumerable<Addrees>>> GetAddressByID(int Id)
        {
            var baseResponse = new BaseResponse<IEnumerable<Addrees>>();
            try
            {
                var branches = await adressRepository.GetAdressById(Id);
                if (branches == null)
                {
                    baseResponse.Description = "<Adress> don't found :-( ";
                    baseResponse.Status = StatusCode.InternalServerError;
                    return baseResponse;
                }
                baseResponse.Data = branches;
                baseResponse.Status = StatusCode.OK;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Addrees>>()
                {
                    Description = $"[GetAddress] : {ex.Message}"
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<Addrees>>> GetAllAddress()
        {
            var baseResponse = new BaseResponse<IEnumerable<Addrees>>();
            try
            {
                var branches = await adressRepository.Select();
                if (branches == null)
                {
                    baseResponse.Description = "<Address> don't found :-( ";
                    baseResponse.Status = StatusCode.InternalServerError;
                    return baseResponse;
                }
                baseResponse.Data = branches;
                baseResponse.Status = StatusCode.OK;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Addrees>>()
                {
                    Description = $"[GetAddress] : {ex.Message}"
                };
            }
        }


    }
}
