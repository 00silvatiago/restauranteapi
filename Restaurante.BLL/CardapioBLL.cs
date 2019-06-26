using Restaurante.BLL.Infra;
using Restaurante.DAL.Infra;
using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL
{
    class CardapioBLL : ICardapioBLL
    {
        private readonly ICardapioRepository _cardapioRepository;

        public CardapioBLL(ICardapioRepository cardapioRepository)
        {
            _cardapioRepository = cardapioRepository;
        }

        public async Task<Cardapio> GetCardapioAsync(int ID_CARDAPIO)
        {
            return await _cardapioRepository.GetCardapioAsync(ID_CARDAPIO);
        }
    }
}
