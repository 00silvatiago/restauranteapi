using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurante.BLL.Infra;
using RestauranteApi.UoW.Infra;

namespace RestauranteApi.UoW
{
    public class LoginUoW : ILoginUoW
    {
        public ILoginBLL loginBLL { get; }

        public LoginUoW(ILoginBLL loginBLL)
        {
            this.loginBLL = loginBLL;
        }
        
    }
}
