using System;
using Microsoft.EntityFrameworkCore;
using Api.Domain.Entities;
using Api.Data.Mapping;
using Api.Data.Seeds;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity> (new UserMap().Configure);

            modelBuilder.Entity<UfEntity> (new UfMap().Configure);
            modelBuilder.Entity<MunicipioEntity> (new MunicipioMap().Configure);
            modelBuilder.Entity<CepEntity> (new CepMap().Configure);

            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Adimistrador",
                    Email = "teste1@email.com.br",
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                }
            );            
            UfSeeds.Ufs(modelBuilder);
        }
    }
}
