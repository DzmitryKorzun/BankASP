using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankSystemASP.DAL.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        bool Create(T entity);
        T GetById(int id);
        Task<List<T>> Select();
        bool Delete(T entity);
    }
}
