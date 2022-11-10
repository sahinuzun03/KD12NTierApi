using KD12NTierApi.DataAccess.EntityFramework.Mapping;
using KD12NTierApi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD12NTierApi.DataAccess.EntityFramework.Context
{
    public class KD12NTierDbContext : DbContext
    {
        public KD12NTierDbContext(DbContextOptions<KD12NTierDbContext> options) : base(options)
        {

        }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonMapping());
        }
    }
}
