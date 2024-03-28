using ConfAppCollector.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfAppCollector.Infrastructure.Core.Configurations
{
    public class ConfApplicationConfiguration : IEntityTypeConfiguration<ConfApplication>
    {
        public void Configure(EntityTypeBuilder<ConfApplication> builder)
        {
            builder.HasKey(s => s.Id);

            builder
                .HasOne(a => a.Speaker)
                .WithOne(s => s.Application)
                .HasForeignKey<ConfApplication>(a => a.Author);
        }
    }
}
