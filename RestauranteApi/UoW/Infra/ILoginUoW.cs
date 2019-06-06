using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurante.BLL.Infra;

namespace RestauranteApi.UoW.Infra
{
    public interface ILoginUoW
    {
        ILoginBLL loginBLL { get; }
    }
}
