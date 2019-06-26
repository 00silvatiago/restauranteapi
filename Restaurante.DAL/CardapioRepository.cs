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
    public class CardapioRepository : RepositoryBase<ICardapioDbContext>, ICardapioRepository
    {
        public CardapioRepository(ICardapioDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Cardapio> GetCardapioAsync(int ID_CARDAPIO)
        {
            return await _dbContext.QueryCardapio.Where(x => x.ID_CARDAPIO.Equals(ID_CARDAPIO)).FirstOrDefaultAsync();
        }
    }
}
