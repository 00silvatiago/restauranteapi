using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL.Infra
{
    public interface IHistoricoVotacaoRepository
    {
        Task<Login> GetHistoricoVotacaoAsync(DateTime HISTVOT_DATA);
    }
}
