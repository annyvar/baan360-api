using Baan360.API.AggregateModels.PropertyAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Baan360.API.DBContexts
{
    [ExcludeFromCodeCoverage]
    public class DBContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            System.Diagnostics.Debug.WriteLine("DBContext::ctor ->" + this.GetHashCode());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await base.SaveChangesAsync();

            return true;
        }
    }
}
