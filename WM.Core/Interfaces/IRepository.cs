using System.Collections.Generic;
using System.Threading.Tasks;
using WM.Core.Entities;

namespace WM.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        Task<T> GetByIdAsync(int id);

        IEnumerable<T> Get();
        Task<List<T>> GetAsync();

        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
