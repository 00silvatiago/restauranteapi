using Restaurante.BLL.Infra;
using RestauranteApi.UoW.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteApi.UoW
{
    public class VotacaoUoW : IVotacaoUoW
    {
        public IVotacaoBLL votacaoBLL { get; }

        public VotacaoUoW(IVotacaoBLL votacaoBLL)
        {
            this.votacaoBLL = votacaoBLL;
        }
    }
}
