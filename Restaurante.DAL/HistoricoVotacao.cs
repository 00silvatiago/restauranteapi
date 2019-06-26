using Microsoft.EntityFrameworkCore;
using Restaurante.DAL.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL
{
    public class HistoricoVotacao : RepositoryBase<IHistoricoVotacaoDbContext>, IHistoricoVotacaoRepository
    {
        public HistoricoVotacao(IHistoricoVotacaoDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Entities.HistoricoVotacao> GetHistoricoVotacaoAsync(DateTime HISTVOT_DATA)
        {
            return await _dbContext.QueryHistoricoVotacao.Where(x => x.HISTVOT_DATA.Equals(HISTVOT_DATA)).FirstOrDefaultAsync();
        }
    }
}
