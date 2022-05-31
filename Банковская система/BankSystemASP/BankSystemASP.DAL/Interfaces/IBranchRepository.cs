using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystemASP.Domain.Entity;
using BankSystemASP.Domain.AuxiliaryModel;

namespace BankSystemASP.DAL.Interfaces
{
    public interface IBranchRepository: IBaseRepository<Branch>
    {
        Task<List<BranchessAddress>> SelectWithAddress();
    }
}
