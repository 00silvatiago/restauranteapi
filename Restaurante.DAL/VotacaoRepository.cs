using Microsoft.EntityFrameworkCore;
using Restaurante.DAL.Infra;
using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL
{
    public class VotacaoRepository : RepositoryBase<IVotacaoDbContext>, IVotacaoRepository
    {
        public VotacaoRepository(IVotacaoDbContext dbContext) : base(dbContext) { }

        public async Task<Votacao> GetVotacaoAsync(DateTime votacaoData)
        {
            try
            {
                return await _dbContext.QueryVotacao
                    .Where(x => x.VOTACAO_DATA.Equals(votacaoData)).FirstOrDefaultAsync();
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
                _dbContext.Add(votacao);

                await _dbContext.SaveChangesAsync();

                return votacao;                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Votacao> PutVotacaoAsync(Votacao votacao)
        {
            try
            {
                _dbContext.SetModified(votacao);

                await _dbContext.SaveChangesAsync();

                return votacao; 
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
