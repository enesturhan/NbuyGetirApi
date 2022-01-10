using NbuyGetir.Core.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Repositories

{
    public interface IEfRepository<TEntity> :IReadOnlyRepository<TEntity>,IWriteOnlyRepository<TEntity> where TEntity: IAggregateRoot
    {
    }
}