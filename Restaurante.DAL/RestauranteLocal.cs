using Microsoft.EntityFrameworkCore;
using Restaurante.DAL.DataBaseContext;
using Restaurante.DAL.Infra;
using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL
{
    public class RestauranteLocal : RepositoryBase<IRestauranteLocalDbContext>, IRestauranteLocalRepository
    {
        public RestauranteLocal(IRestauranteLocalDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Entities.RestauranteLocal> GetAlunoAsync(int ID_RESTAURANTE)
        {
            return await _dbContext.QueryRestauranteLocal.Where(x => x.ID_CARDAPIO.Equals(ID_RESTAURANTE)).FirstOrDefaultAsync();
        }

        public async Task<Entities.RestauranteLocal> PostAlunoAsync(Entities.RestauranteLocal restauranteLocal)
        {
            try
            {
                _dbContext.Add(restauranteLocal);
                await _dbContext.SaveChangesAsync();

                return restauranteLocal;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public async Task<Entities.RestauranteLocal> PutAlunoAsync(Entities.RestauranteLocal restauranteLocal)
        {
            try
            {
                _dbContext.SetModified(restauranteLocal);
                await _dbContext.SaveChangesAsync();

                return restauranteLocal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
