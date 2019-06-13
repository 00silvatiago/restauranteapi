using Restaurante.BLL.Infra;
using RestauranteApi.UoW.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteApi.UoW
{
    public class AlunoUoW : IAlunoUoW
    {
        public IAlunoBLL alunoBLL { get; }

        public AlunoUoW(IAlunoBLL alunoBLL)
        {
            this.alunoBLL = alunoBLL; 
        }
    }
}
