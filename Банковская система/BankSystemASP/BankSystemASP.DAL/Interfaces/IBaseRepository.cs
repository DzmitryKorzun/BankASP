using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystemASP.DAL.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task Create(T entity);
        IQueryable<T> GetById(int id);
        Task<List<T>> Select();
        bool Delete(T entity);
        IEnumerable<T> GetAll();
    }
}
