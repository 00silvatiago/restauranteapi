using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Restaurante.DAL.Infra;
using Restaurante.Entities;

namespace Restaurante.DAL.DataBaseContext
{
    public class RestauranteDbContext : DbContext, ILoginDbContext, IAlunoDbContext, IVotacaoDbContext, ICardapioDbContext, IHistoricoVotacaoDbContext, IRestauranteLocalDbContext                                                         
    {
        private IConfiguration configuration;

        public RestauranteDbContext(IConfiguration config)
        {
            configuration = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = configuration.GetConnectionString("RestauranteDbBase");
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }

        public void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        public DbSet<Login> Login { get; set; }
        public IQueryable<Login> QueryLogin { get { return Login; } }

        public DbSet<Aluno> Aluno { get; set; }
        public IQueryable<Aluno> QueryAluno { get { return Aluno; } }

        public DbSet<Votacao> Votacao { get; set; }
        public IQueryable<Votacao> QueryVotacao { get { return Votacao; } }

        public DbSet<Cardapio> Cardapio { get; set; }
        public IQueryable<Cardapio> QueryCardapio { get { return Cardapio; } }

        public DbSet<Entities.RestauranteLocal> RestauranteLocal { get; set; }
        //public IQueryable<RestauranteLocal> QueryRestauranteLocal { get { return RestauranteLocal; } }
        IQueryable<Entities.RestauranteLocal> IRestauranteLocalDbContext.QueryRestauranteLocal { get { return RestauranteLocal; } }

        public DbSet<Entities.HistoricoVotacao> HistoricoVotacao { get; set; }
        //public IQueryable<HistoricoVotacao> QueryHistoricoVotacao { get { return HistoricoVotacao; } }
        IQueryable<Entities.HistoricoVotacao> IHistoricoVotacaoDbContext.QueryHistoricoVotacao { get { return HistoricoVotacao; } }

        
    }
}
