using System;
using Api.Data.Mapping;
using Api.Data.Seeds;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }  // Configuração padrão

        protected override void OnModelCreating(ModelBuilder modelBuilder)   // Configuração padrão
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<CityEntity>(new CityMap().Configure);
            modelBuilder.Entity<CodeZipEntity>(new CodeZipeMap().Configure);
            modelBuilder.Entity<UfEntity>(new UfMap().Configure);
            UfSeeds.Ufs(modelBuilder); //irá criar os estados que estão cadastrado in mock
            modelBuilder.Entity<UserEntity>().HasData( //irá criar um usuário para acessar a aplicação
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "administrador",
                    Email = "administrador@geral.com",
                    CreatedAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                });
        }

    }
}
