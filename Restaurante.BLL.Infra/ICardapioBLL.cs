using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL.Infra
{
    public interface ICardapioBLL
    {
        Task<Cardapio> GetCardapioAsync(int ID_CARDAPIO);
    }
}
