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
    public class RestauranteDbContext : DbContext, IRestauranteDbContext
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
         
    }
}
