using Restaurante.BLL.Infra;
using Restaurante.DAL.Infra;
using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL
{
    public class HistoricoVotacaoBLL : IHistoricoVotacaoBLL
    {
        private readonly IHistoricoVotacaoRepository _historicoVotacaoRepository;

        public async Task<Entities.HistoricoVotacao> GetHistoricoVotacaoAsync(DateTime HISTVOT_DATA)
        {
            return await _historicoVotacaoRepository.GetHistoricoVotacaoAsync(HISTVOT_DATA);
        }
    }
}
