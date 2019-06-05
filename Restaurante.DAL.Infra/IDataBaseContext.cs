using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Restaurante.DAL.Infra
{
    interface IDataBaseContext : IDisposable
    {
        ChangeTracker ChangeTracker {get; }
        DatabaseFacade Database { get; }
        IModel Model { get; }

        EntityEntry Add(object entity);
        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;
        Task<EntityEntry> AddAsync(object entity, CancellationToken cancellationToken = default(CancellationToken));
        Task<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default(CancellationToken)) where TEntity : class;
        void AddRange(IEnumerable<object> entities);
        void AddRange(params object[] entities);
        Task AddRangeAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default(CancellationToken));




    }
}
