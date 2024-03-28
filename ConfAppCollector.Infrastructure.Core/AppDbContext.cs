using ConfAppCollector.Domain.Entities;
using ConfAppCollector.Infrastructure.Core.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Runtime;

namespace ConfAppCollector.Infrastructure.Core
{
    public class AppDbContext : DbContext
    {

        public DbSet<Speaker> Authors {  get; set; }
        public DbSet<ConfApplication> ConfApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfApplicationConfiguration());
            modelBuilder.ApplyConfiguration(new SpeakerConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        string conn = "Host=localhost;Port=5432;Database=db;Username=admin;Password=123";
        //        optionsBuilder.UseNpgsql(conn, sql => sql.MigrationsAssembly("ConfAppCollector.Infrastructure.Core"));
        //    }
        //    base.OnConfiguring(optionsBuilder);

        //}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Database.Migrate();
        }
    }
}
