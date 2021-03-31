using Leoni.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Leoni.Infraestructure.Persistance.Context
{
    public interface IApplicationDbContext : IDisposable
    {
        DbSet<Analysis> Analysis { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        int SaveChanges();
    }
}
