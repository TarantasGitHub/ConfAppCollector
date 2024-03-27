using ConfAppCollector.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Runtime;

namespace ConfAppCollector.Infrastructure.Core
{
    public class AppDbContext : DbContext
    {

        public DbSet<Speaker> Authors => Set<Speaker>();
        public DbSet<ConfApplication> ConfApplications => Set<ConfApplication>();


        public AppDbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }

    }
}
