using Restaurante.BLL.Infra;
using Restaurante.DAL.Infra;
using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL
{
    public class AlunoBLL : IAlunoBLL
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoBLL(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository; 
        }

        public async Task<Aluno> GetAlunoAsync(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("Preencha o nome do aluno");
                }

                return await _alunoRepository.GetAlunoAsync(name);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public async Task<Aluno> PostAlunoAsync(Aluno aluno)
        {
            try
            {
                if (string.IsNullOrEmpty(aluno.ALUNO_NOME))
                {
                    throw new Exception("Preencha o nome do aluno");
                }

                return await _alunoRepository.PostAlunoAsync(aluno);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Aluno> PutAlunoAsync(Aluno aluno)
        {
            try
            {
                if (string.IsNullOrEmpty(aluno.ALUNO_NOME))
                {
                    throw new Exception("Insira todas as informações");   
                }

                return await _alunoRepository.PutAlunoAsync(aluno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
