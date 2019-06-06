using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurante.BLL.Infra;
using Restaurante.DAL.Infra;
using Restaurante.Entities;

namespace Restaurante.BLL
{
    public class LoginBLL : ILoginBLL
    {
        private readonly ILoginRepository _loginRepository;

        public LoginBLL(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository; 
        }

        public async Task<Login> GetLoginAsync(string name, string pwd)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new Exception("Preencha o nome de usuário");
                }

                if (string.IsNullOrWhiteSpace(pwd))
                {
                    throw new Exception("Preencha a senha");
                }

                return await _loginRepository.GetLoginAsync(name, pwd); 

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Login> PostLoginAsync(Login login)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(login.LGN_LOGIN))
                {
                    throw new Exception("Preencha o nome de usuário");
                }

                if(string.IsNullOrWhiteSpace(login.LGN_SENHA))
                {
                    throw new Exception("Preencha a senha");
                }

                return await _loginRepository.PostLoginAsync(login); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Login> PutLoginAsync(Login login)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(login.LGN_LOGIN))
                {
                    throw new Exception("Preencha o nome de usuário");
                }

                if(string.IsNullOrWhiteSpace(login.LGN_SENHA))
                {
                    throw new Exception("Preencha a senha");
                }

                return await _loginRepository.PutLoginAsync(login);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
