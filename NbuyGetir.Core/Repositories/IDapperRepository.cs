using NbuyGetir.Core.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Repositories
{
    public interface IDapperRepository<TEntity>: IReadOnlyRepository<TEntity> where TEntity : IAggregateRoot
    {



    }
}
