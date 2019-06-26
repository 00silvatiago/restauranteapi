using Restaurante.BLL.Infra;
using RestauranteApi.UoW.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteApi.UoW
{
    public class RestauranteLocalUoW : IRestauranteLocalUoW
    {
        public IRestauranteLocalBLL restauranteLocalBLL { get; }

        public RestauranteLocalUoW(IRestauranteLocalBLL restauranteLocalBLL)
        {
            this.restauranteLocalBLL = restauranteLocalBLL;
        }      
    }
}
