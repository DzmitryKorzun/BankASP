using BankSystemASP.DAL.Interfaces;
using BankSystemASP.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext dbContext;
        public UserRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool Create(User entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetById(int id) => await dbContext.Users.FromSqlRaw($"SELECT * FROM Users WHERE idUser = {id}").FirstOrDefaultAsync();

        public async Task<List<User>> Select() => await dbContext.Users.ToListAsync();

        Task<List<User>> IBaseRepository<User>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
