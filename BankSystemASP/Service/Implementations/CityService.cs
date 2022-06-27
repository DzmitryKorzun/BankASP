using BankSystemASP.DAL.Interfaces;
using BankSystemASP.Domain.Entity;
using BankSystemASP.Domain.Response;
using BankSystemASP.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Service.Implementations
{
    public class CityService : ICityService
    {
        private readonly ICityRepository cityRepository;
        public CityService(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<BaseResponse<List<City>>> GetCityByRegion(string Region)
        {
            var baseResponse = new BaseResponse<List<City>>();
            var result = await cityRepository.GetCitiesByRegion(Region);
            if (result != null)
            {
                baseResponse.Data = result;
                baseResponse.Status = Domain.Enum.StatusCode.OK;
            }
            else
            {
                baseResponse.Data = null;
                baseResponse.Status = Domain.Enum.StatusCode.InternalServerError;
            }
            return baseResponse;
        }
    }
}
