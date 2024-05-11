using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSport.Api.DataAccess.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> Entities { get; }

        Task<T?> GetByIdAsync(int id);

        Task<List<T>> GetAllAsync();

        Task AddAsync(T TEntity);

        Task UpdateAsync(T TEntity);

        Task DeleteAsync(T TEntity);
    }
}
