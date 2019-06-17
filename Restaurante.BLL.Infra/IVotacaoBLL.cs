using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL.Infra
{
    public interface IVotacaoBLL
    {
        Task<Votacao> GetVotacaoAsync(DateTime dataVotacao);
        Task<Votacao> PostVotacaoAsync(Votacao votacao);
        Task<Votacao> PutVotacaoAsync(Votacao votacao);

    }
}
