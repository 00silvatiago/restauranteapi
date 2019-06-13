using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL.Infra
{
    public interface IVotacaoRepository
    {
        Task<Votacao> GetVotacaoAsync(DateTime votacaoData);
        Task<Votacao> PostVotacaoAsync(Votacao votacao);
        Task<Votacao> PutVotacaoAsync(Votacao votacao);
    }
}
