using BankSystemASP.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.DAL.Interfaces
{
    public interface IAddressRepository: IBaseRepository<Addrees>
    {
        Task<Addrees> GetAdressById(int id);
    }
}
