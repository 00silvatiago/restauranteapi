using Restaurante.BLL.Infra;
using RestauranteApi.UoW.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteApi.UoW
{
    public class CardapioUoW : ICardapioUoW
    {
        public ICardapioBLL cardapioBLL { get; }

        public CardapioUoW(ICardapioBLL cardapioBLL)
        {
            this.cardapioBLL = cardapioBLL;
        }    
    }
}
