using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL.Infra
{
    public interface IHistoricoVotacaoBLL
    {
        Task<HistoricoVotacao> GetHistoricoVotacaoAsync(DateTime HISTVOT_DATA);
    }
}
