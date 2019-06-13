using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL.Infra
{
    public interface IRestauranteLocalRepository
    {
        Task<RestauranteLocal> GetAlunoAsync(int ID_RESTAURANTE);
        Task<RestauranteLocal> PostAlunoAsync(RestauranteLocal restauranteLocal);
        Task<RestauranteLocal> PutAlunoAsync(RestauranteLocal restauranteLocal);
    }
}
