using BankSystemASP.DAL;
using BankSystemASP.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BankSystemASP.Helpers
{
    public class InitDataBase
    {
        public InitDataBase(ApplicationDbContext db)
        {
            this.db = db;
        }

        private readonly ApplicationDbContext db;

        public void InitAsync()
        {
            string sqlInserts;
            using (StreamReader reader = new StreamReader("DB_Script.sql"))
            {
                sqlInserts = reader.ReadToEnd();
            }
            try
            {
                db.Database.ExecuteSqlRaw(sqlInserts);
            }
            catch
            {

            }
        }











    }
}
