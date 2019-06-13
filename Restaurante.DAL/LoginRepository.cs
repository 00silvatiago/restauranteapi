using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurante.DAL.Infra;
using Restaurante.Entities;

namespace Restaurante.DAL
{
    public class LoginRepository : RepositoryBase<ILoginDbContext>, ILoginRepository
    {
        public LoginRepository(ILoginDbContext dbContext) : base(dbContext)
        {}

        /// <summary>
        /// METODO RESPONSÁVEL POR RETORNAR O LOGIN DO USUÁRIO
        /// </summary>
        /// <param name="name">NOME DO USUÁRIO</param>
        /// <param name="pwd">SENHA DO USUÁRIO</param>
        /// <returns></returns>
        public async Task<Login> GetLoginAsync(string name, string pwd)
        {
            try
            {
                return await _dbContext.QueryLogin
                    .Where(x => x.LGN_LOGIN.Equals(name) && x.LGN_SENHA.Equals(pwd)).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// MÉTODO RESPONSAVEL POR PERSISTIR O LOGIN DO USUÁRIO 
        /// </summary>
        /// 
        /// <param name="login">OBJETO LOGIN</param>
        /// <returns>OBJETO LOGIN</returns>
            
        public async Task<Login> PostLoginAsync(Login login)
        {
            try
            {
                _dbContext.Add(login);
                await _dbContext.SaveChangesAsync();

                return login; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// METODO RESPONSAVEL POR ATUALIZAR O LOGIN DO SISTEMA
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<Login> PutLoginAsync(Login login)
        {
            try
            {
                _dbContext.SetModified(login);
                await _dbContext.SaveChangesAsync();

                return login;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
    }
}
