using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystemASP.DAL.Interfaces;
using BankSystemASP.Domain.AuxiliaryModel;
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

        public bool Delete(Branch entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Branch> GetAll()
        {
            return dbContext.Branches;
        }

        public async Task<Branch> GetBranchByNumber(int number)
        {
            return await dbContext.Branches.FirstAsync(x=>x.Namber == number);
        }

        public IQueryable<Branch> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Branch> GetIdByNumber(string request)
        {
            return  dbContext.Branches.FromSqlRaw(request).FirstOrDefault();
        }

        public async Task<List<Branch>> Select(string request)
        {
            var res = await dbContext.Branches.ToListAsync();
            return res;
        }

        public async Task<List<int>> SelectAllBranchNumbers(string request)
        {            
            return await dbContext.Branches.FromSqlRaw(request).Select(column=>column.Namber).ToListAsync();
        }

        public async Task<List<BranchessAddress>> SelectWithAddress()
        {
            return await dbContext.Branches.Select(x => new BranchessAddress
            {
                Namber = x.Namber,
                IdBranch = x.IdBranch,
                WorkTime = x.WorkTime,
                IsElectronicQueue = x.IsElectronicQueue,
                IsForInvalid = x.IsForInvalid,
                IsHaveWiFi = x.IsHaveWiFi,
                IsHaveParking = x.IsHaveParking,
                IsPreEntry = x.IsPreEntry,
                IsWorksOnWeekends = x.IsWorksOnWeekends,
                AddreesStreet = $"{x.Addrees.street}",
                AddreesCity = $"{x.Addrees.city.name}",
                AddreesRegion = $"{x.Addrees.city.region.name}",
                Building = $"{x.Addrees.building}",
                StreetType = $"{x.Addrees.streetType.name}",
                addrees = dbContext.Addrees.ToArray(),
                cities = dbContext.Cities.ToArray(),
                regions = dbContext.Regions.ToArray(),
                
            }).ToListAsync();
        }

        async Task IBaseRepository<Branch>.Create(Branch entity)
        {
            dbContext.Branches.Add(entity);
            await dbContext.SaveChangesAsync();
        }

    }
}
