using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Restaurante.Helpers;
using RestauranteApi;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Xunit;

namespace Restaurante.Test
{
    public class LoginTest
    {
        private readonly HttpClient _client;
        public LoginTest()
        {
            try
            {
                string curDir = @"C:\restauranteapi\RestauranteApi";

                var server = new TestServer(new WebHostBuilder()
                        .UseContentRoot(curDir)
                        .UseConfiguration(
                            new ConfigurationBuilder()
                            .SetBasePath(curDir)
                            .AddJsonFile("appsettings.json")
                            .Build()
                        )                                         
                    .UseStartup<Startup>());

                _client = server.CreateClient();                   
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }


        [Fact]
        public async void LoginAsync()
        {
            var name = "TIAGS38";
            var pwd = "1a6";
            var responseContent = new ResponseContent();

            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseApi = await _client.GetAsync("api/login/get?name=" + name + "&pwd=" + pwd);

            if (responseApi.IsSuccessStatusCode)
            {
                responseContent = await responseApi.Content.ReadAsAsync<ResponseContent>(); 
            }

            Assert.True(responseContent.Status); 
        }
    }
}
