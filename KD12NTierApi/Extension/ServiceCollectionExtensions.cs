using KD12NTierApi.Bussiness.Abstract;
using KD12NTierApi.Bussiness.Concrete;
using KD12NTierApi.DataAccess.Abstract;
using KD12NTierApi.DataAccess.EntityFramework.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD12NTierApi.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static void Scoped(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPersonService, PersonService>();
        }

    }
}
