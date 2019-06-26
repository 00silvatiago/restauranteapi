using Restaurante.BLL.Infra;
using RestauranteApi.UoW.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteApi.UoW
{
    public class HistoricoVotacaoUoW : IHistoricoVotacaoUoW
    {
        public IHistoricoVotacaoBLL historicoVotacaoBLL { get; }

        public HistoricoVotacaoUoW(IHistoricoVotacaoBLL historicoVotacaoBLL)
        {
            this.historicoVotacaoBLL = historicoVotacaoBLL;
        }
    }
}
