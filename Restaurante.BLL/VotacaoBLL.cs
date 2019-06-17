using Restaurante.BLL.Infra;
using Restaurante.DAL.Infra;
using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL
{
    public class VotacaoBLL : IVotacaoBLL
    {
        public readonly IVotacaoRepository _votacaoRepository;

        public VotacaoBLL(IVotacaoRepository votacaoRepository)
        {
            _votacaoRepository = votacaoRepository; 
        }

        public async Task<Votacao> GetVotacaoAsync(DateTime dataVotacao)
        {
            try
            {
                return await _votacaoRepository.GetVotacaoAsync(dataVotacao);
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }

        public async Task<Votacao> PostVotacaoAsync(Votacao votacao)
        {
            try
            {
                return await _votacaoRepository.PostVotacaoAsync(votacao);                 
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }

        public async Task<Votacao> PutVotacaoAsync(Votacao votacao)
        {
            try
            {
                return await _votacaoRepository.PutVotacaoAsync(votacao); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
