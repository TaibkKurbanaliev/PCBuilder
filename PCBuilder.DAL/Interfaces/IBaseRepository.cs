using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<bool> Create(T entity);
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<bool> Delete(int id);
        Task<bool> Edit(T entity);
        Task<bool> Save();
    }
}
