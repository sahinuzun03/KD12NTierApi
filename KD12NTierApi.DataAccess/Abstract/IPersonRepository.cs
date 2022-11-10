using KD12NTierApi.Core.DataAccess.Abstract;
using KD12NTierApi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD12NTierApi.DataAccess.Abstract
{
    public interface IPersonRepository : IRepository<Person>
    {
    }
}
