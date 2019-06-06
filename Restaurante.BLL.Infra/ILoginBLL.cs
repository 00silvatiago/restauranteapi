using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurante.Entities;

namespace Restaurante.BLL.Infra
{
    public interface ILoginBLL
    {
        Task<Login> GetLoginAsync(string name, string pwd);
        Task<Login> PostLoginAsync(Login login);
        Task<Login> PutLoginAsync(Login login);
    }
}
