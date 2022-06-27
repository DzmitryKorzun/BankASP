using BankSystemASP.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.DAL.Interfaces
{
    public interface ICityRepository:IBaseRepository<City>
    {
        public Task<List<City>> GetCitiesByRegion(string region);
    }
}
