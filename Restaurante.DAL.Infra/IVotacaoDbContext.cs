using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurante.DAL.Infra
{
    public interface IVotacaoDbContext : IDataBaseContext
    {
        IQueryable<Votacao> QueryVotacao { get; }
    }
}
