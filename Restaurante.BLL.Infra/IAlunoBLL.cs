using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL.Infra
{
    public interface IAlunoBLL
    {
        Task<Aluno> GetAlunoAsync(string name);
        Task<Aluno> PostAlunoAsync(Aluno aluno);
        Task<Aluno> PutAlunoAsync(Aluno aluno);
    }
}
