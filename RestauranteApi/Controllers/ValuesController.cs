using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestauranteApi.Controllers
{   
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("api/values")]           
        public IActionResult GetName(string name)
        {
            try
            {
                return Ok(name + " o Guilherme é muito viado");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}