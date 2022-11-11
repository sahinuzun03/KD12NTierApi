using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KD12NTierApi.Core.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Add(T entity);
        Task<bool> AddRange(List<T> entities);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<List<T>> GetAll();
        Task<T> GetByID(int id);
        Task<int> Save();
    }
}
