using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusWebApp.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);

        void Remove(int id);

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<int> SaveAsync();

    
    }
}
