using System.Collections.Generic;
using System.Threading.Tasks;
using BankSystemASP.Domain.Entity;
using BankSystemASP.Domain.AuxiliaryModel;

namespace BankSystemASP.DAL.Interfaces
{
    public interface IBranchRepository: IBaseRepository<Branch>
    {
        Task<List<BranchessAddress>> SelectWithAddress();
        Task<List<int>> SelectAllBranchNumbers(string request);
        Task<Branch> GetIdByNumber(string request);
        Task<Branch> GetBranchByNumber(int number);
    }
}
