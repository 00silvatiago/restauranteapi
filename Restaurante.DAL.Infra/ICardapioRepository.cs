using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL.Infra
{
    public interface ICardapioRepository
    {
        Task<Cardapio> GetCardapioAsync(int ID_CARDAPIO);
        Task<Cardapio> PostCardapioAsync(Cardapio cardapio);
        Task<Cardapio> PutCardapioAsync(Cardapio cardapio);
    }
}
