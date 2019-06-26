using Restaurante.BLL.Infra;
using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL
{
    public class RestauranteLocalBLL : IRestauranteLocalBLL
    {
        private readonly IRestauranteLocalBLL _restauranteLocal;

        public Task<RestauranteLocal> GetRestauranteLocalAsync(int ID_RESTAURANTE)
        {
            return _restauranteLocal.GetRestauranteLocalAsync(ID_RESTAURANTE);
        }

        public Task<RestauranteLocal> PostRestauranteLocalAsync(RestauranteLocal restauranteLocal)
        {
            return null;
        }

        public Task<RestauranteLocal> PutRestauranteLocalAsync(RestauranteLocal restauranteLocal)
        {
            return null;
        }
    }
}
