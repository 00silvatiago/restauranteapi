using Restaurante.BLL.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteApi.UoW.Infra
{
    interface IRestauranteLocalUoW
    {
        IRestauranteLocalBLL restauranteLocalBLL { get; }
    }
}
