using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL.Infra
{
    public interface IRestauranteLocalBLL
    {
        Task<RestauranteLocal> GetRestauranteLocalAsync(int ID_RESTAURANTE);
        Task<RestauranteLocal> PostRestauranteLocalAsync(RestauranteLocal restauranteLocal);
        Task<RestauranteLocal> PutRestauranteLocalAsync(RestauranteLocal restauranteLocal);
    }
}
