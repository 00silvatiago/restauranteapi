using System;
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
    //[Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private IAlunoUoW _alunoUoW;   
        
        public AlunoController(IAlunoUoW alunoUoW)
        {
            _alunoUoW = alunoUoW;
        }

        [Route("api/aluno/get"), HttpGet]

        public async Task<IActionResult> GetAluno(string name)
        {
            var response = new ResponseContent();

            try
            {
                response.Object = await _alunoUoW.alunoBLL.GetAlunoAsync(name);
                response.Message = "Requisição realizada com sucesso.";
                response.Status = true; 
            }
            catch(Exception ex)
            {
                response.Message = ex.Message; 
                response.Status = false; 
            }

            return Ok(response);
        }
    }
}