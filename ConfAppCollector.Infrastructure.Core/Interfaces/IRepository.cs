using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfAppCollector.Infrastructure.Core.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> AddAsync(T entity, bool saveChanges = true, CancellationToken cancellationToken = default);

    }
}
