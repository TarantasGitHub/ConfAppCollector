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
    public class SpeakerConfiguration : IEntityTypeConfiguration<Speaker>
    {
        public void Configure(EntityTypeBuilder<Speaker> builder)
        {
            builder.HasKey(s => s.Author);

            builder
                .HasOne(s => s.Application)
                .WithOne(a => a.Speaker)
                .HasForeignKey<Speaker>(a => a.ApplicationId);
        }
    }
}
