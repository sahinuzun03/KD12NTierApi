using KD12NTierApi.DataAccess.Abstract;
using KD12NTierApi.DataAccess.EntityFramework.Abstract;
using KD12NTierApi.DataAccess.EntityFramework.Context;
using KD12NTierApi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD12NTierApi.DataAccess.EntityFramework.Concrete
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(KD12NTierDbContext kD12NTierDbContext) : base(kD12NTierDbContext)
        {
        }
    }
}
