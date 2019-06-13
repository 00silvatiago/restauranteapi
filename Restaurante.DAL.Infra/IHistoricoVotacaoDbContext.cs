using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurante.DAL.Infra
{
    public interface IHistoricoVotacaoDbContext : IDataBaseContext
    {
        IQueryable<HistoricoVotacao> QueryHistoricoVotacao { get; }
    }
}
