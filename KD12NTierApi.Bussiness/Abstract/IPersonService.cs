using KD12NTierApi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD12NTierApi.Bussiness.Abstract
{
    public interface IPersonService
    {
        Task<bool> Add(Person entity);
        Task<bool> AddRange(List<Person> entities);
        Task<bool> Update(Person entity);
        Task<bool> Delete(Person entity);
        Task<List<Person>> GetAll();
        Task<Person> GetByID(Guid id);
    }
}
