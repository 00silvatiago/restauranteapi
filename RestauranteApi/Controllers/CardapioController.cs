using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Helpers;
using RestauranteApi.UoW.Infra;

namespace RestauranteApi.Controllers
{
    [ApiController]
    public class CardapioController : ControllerBase
    {
        private ICardapioUoW _cardapioUoW;

        public CardapioController(ICardapioUoW cardapioUoW)
        {
            _cardapioUoW = cardapioUoW;
        }

        [Route("api/cardapio/get"), HttpGet]
        public async Task<IActionResult> GetCardapio(int ID_CARDAPIO)
        {
            var response = new ResponseContent();

            try
            {
                response.Message = "Requisição realizada com sucesso";
                response.Status = true;
                response.Object = await _cardapioUoW.cardapioBLL.GetCardapioAsync(ID_CARDAPIO);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false; 
            }

            return Ok(response);
        }
    }
}