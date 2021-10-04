using Microsoft.EntityFrameworkCore;
using Opet.App.Business;
using System;

namespace Opet.App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)  { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<User>()
                .Property(p => p.Nome)
                    .HasMaxLength(80);

            modelBuilder.Entity<User>()
                .Property(p => p.Email)
                    .HasMaxLength(80);

            modelBuilder.Entity<User>()
                .HasData(
                    new User { Id = 1, Nome = "Paulin Bacana", Email = "paulinbacana@gmail.com", Senha = "Teste@bacana123" });
                    //new User { Nome = "Paulin Mediana", Email = "paulinmediana@gmail.com", Senha = "Teste@mediana123" },
                    //new User { Nome = "Paulin Sacana", Email = "paulinsacana@gmail.com", Senha = "Teste@sacana123" });
        }

    }
}
