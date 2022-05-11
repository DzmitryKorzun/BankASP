using BankSystemASP.Domain.Entity;
using BankSystemASP.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Service.Interfaces
{
    public interface IBranchServise
    {
        Task<IBaseResponse<IEnumerable<Branch>>> GetAllBranches();
    }
}
