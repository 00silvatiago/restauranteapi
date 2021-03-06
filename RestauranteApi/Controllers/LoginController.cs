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
    //[Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginUoW _loginUoW;

        public LoginController(ILoginUoW loginUoW)
        {
            _loginUoW = loginUoW;
        }

        /// <summary>
        /// SALVAR DADOS DE ACESSO DO USUÁRIO
        /// </summary>
        /// <param name="login">OBJETO LOGIN</param>
        /// <returns>OBJETO RESPONSE</returns>
        [Route("api/login/post"), HttpPost]
        public async Task<IActionResult> PostLogin(Login login)
        {
            var response = new ResponseContent();

            try
            {
                response.Object = await _loginUoW.loginBLL.PostLoginAsync(login);
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

        [Route("api/login/get"), HttpGet]
        public async Task<IActionResult> GetLogin(string name, string pwd)
        {
            var response = new ResponseContent();

            try
            {
                response.Object = await _loginUoW.loginBLL.GetLoginAsync(name, pwd);
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

        [Route("api/login/put"), HttpPut]
        public async Task<IActionResult> PutLogin(Login login)
        {
            var response = new ResponseContent();
            try
            {
                response.Object = await _loginUoW.loginBLL.PutLoginAsync(login);
                response.Message = "Requisição realizada com sucesso. ";
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