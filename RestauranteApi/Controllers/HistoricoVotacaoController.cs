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
    public class HistoricoVotacaoController : ControllerBase
    {
        private IHistoricoVotacaoUoW _historicoVotacaoUoW;

        public HistoricoVotacaoController(IHistoricoVotacaoUoW historicoVotacaoUoW)
        {
            _historicoVotacaoUoW = historicoVotacaoUoW;
        }

        [Route("api/historicovotacao/get"), HttpGet]
        public async Task<IActionResult> GetAluno(DateTime HISTVOT_DATA)
        {
            var response = new ResponseContent();

            try
            {
                response.Object = await _historicoVotacaoUoW.historicoVotacaoBLL.GetHistoricoVotacaoAsync(HISTVOT_DATA);
                response.Message = "Requisição realizada com sucesso.";
                response.Status = true;
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