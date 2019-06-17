﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Entities;
using Restaurante.Helpers;
using RestauranteApi.UoW.Infra;


namespace RestauranteApi.Controllers
{
    public class VotacaoController
    {
        private IVotacaoUoW _votacaoUoW;

        public VotacaoController(IVotacaoUoW votacaoUoW)
        {
            _votacaoUoW = votacaoUoW;
        }


        [Route("api/votacao/get"), HttpGet]
        public async Task<IActionResult> GetVotacao(DateTime dataVotacao)
        {
            var response = new ResponseContent();

            try
            {
                response.Object = await _votacaoUoW.votacaoBLL.GetVotacaoAsync(dataVotacao);
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

        private IActionResult Ok(ResponseContent response)
        {
            throw new NotImplementedException();
        }
    }
}