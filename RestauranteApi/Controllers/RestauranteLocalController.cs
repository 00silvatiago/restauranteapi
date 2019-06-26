using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Helpers;
using RestauranteApi.UoW;

namespace RestauranteApi.Controllers
{
    [ApiController]
    public class RestauranteLocalController : ControllerBase
    {
        private RestauranteLocalUoW _restauranteLocalUoW;

        public RestauranteLocalController(RestauranteLocalUoW restauranteLocalUoW)
        {
            _restauranteLocalUoW = restauranteLocalUoW;
        }

        [Route("api/restaurante/get")]
        public async Task<IActionResult> GetRestauranteAsync(int ID_RESTAURANTE)
        {
            var response = new ResponseContent();

            try
            {
                response.Object = await _restauranteLocalUoW.restauranteLocalBLL.GetRestauranteLocalAsync(ID_RESTAURANTE);
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