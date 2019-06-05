using System;
using System.Collections.Generic;
using System.Text;
using Restaurante.DAL.Infra;

namespace Restaurante.DAL
{
    public abstract class RepositoryBase<TContext> where TContext : IRestauranteDbContext
    {
        protected TContext _dbContext;

        public RepositoryBase(TContext dbContext)
        {
            _dbContext = dbContext
        }

    }
}
