using ConfAppCollector.Domain.Entities;
using ConfAppCollector.Infrastructure.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfAppCollector.Infrastructure.Core.Implementations
{
    public class SpeakerRepository : Repository<Speaker>, ISpeakerRepository
    {
        public SpeakerRepository(AppDbContext appDbContext) : base(appDbContext)
        { }
    }
}
