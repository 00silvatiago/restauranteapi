using Microsoft.EntityFrameworkCore;
using Restaurante.DAL.Infra;
using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL
{
    public class AlunoRepository : RepositoryBase<IAlunoDbContext>, IAlunoRepository
    {
        public AlunoRepository(IAlunoDbContext dbContext) : base(dbContext){}

        public async Task<Aluno> GetAlunoAsync(string name)
        {
            try
            {
                return await _dbContext.QueryAluno
                        .Where(x => x.ALUNO_NOME.Equals(name)).FirstOrDefaultAsync(); 
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
                _dbContext.Add(aluno);
                await _dbContext.SaveChangesAsync();

                return aluno;                                  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Aluno> PutAlunoAsync(Aluno aluno)
        {
            try
            {
                _dbContext.SetModified(aluno);
                await _dbContext.SaveChangesAsync();

                return aluno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
