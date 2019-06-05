using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurante.Entities;

namespace Restaurante.DAL.Infra
{
    public interface ILoginRepository
    {
        Task<Login> GetLoginAsync(string name, string pwd);
        Task<Login> PutLoginAsync(Login login);
        Task<Login> PostLoginAsync(Login login);

    }
}
