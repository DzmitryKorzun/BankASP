using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystemASP.DAL.Interfaces;
using BankSystemASP.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace BankSystemASP.DAL.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        private readonly ApplicationDbContext dbContext;
        public BranchRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool Create(Branch entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Branch entity)
        {
            throw new NotImplementedException();
        }

        public Branch GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Branch>> Select() => await dbContext.Branches.ToListAsync();

        Task<List<Branch>> IBaseRepository<Branch>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
