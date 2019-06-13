using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurante.Entities;

namespace Restaurante.DAL.Infra
{
    public interface IAlunoRepository
    {
        Task<Aluno> GetAlunoAsync(string name);
        Task<Aluno> PostAlunoAsync(Aluno aluno);
        Task<Aluno> PutAlunoAsync(Aluno aluno);      
    }
}
