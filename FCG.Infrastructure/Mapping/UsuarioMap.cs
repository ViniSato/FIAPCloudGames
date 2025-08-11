using FCG.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FCG.Infrastructure.Mapping
{
    public static class UsuarioMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .ToTable("usuarios");

            modelBuilder.Entity<Usuario>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Id)
                .HasColumnName("id");

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome");

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Email)
                .HasMaxLength(100)
                .HasColumnName("email");

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Idade)
                .HasColumnName("idade");

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Pais)
                .HasMaxLength(50)
                .HasColumnName("pais");

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Sexo)
                .HasColumnName("sexo");

            modelBuilder.Entity<Usuario>()
                .Property(x => x.SenhaHash)
                .HasMaxLength(255)
                .HasColumnName("senha_hash");

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Imagem)
                .HasColumnName("imagem");

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Ativo)
                .HasColumnName("ativo");

            modelBuilder.Entity<Usuario>()
                .Property(x => x.CriadoEm)
                .HasColumnName("criado_em");

            modelBuilder.Entity<Usuario>()
                .Property(x => x.AtualizadoEm)
                .HasColumnName("atualizado_em");

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Nivel)
                .HasMaxLength(50)
                .HasColumnName("nivel");

            modelBuilder.Entity<Usuario>()
                .HasMany(x => x.GenerosFavoritos)
                .WithOne()
                .HasForeignKey("UsuarioId");

            modelBuilder.Entity<Usuario>()
                .HasMany(x => x.Wishlist)
                .WithOne()
                .HasForeignKey("UsuarioId");

            modelBuilder.Entity<Usuario>()
                .HasMany(x => x.Jogos)
                .WithOne()
                .HasForeignKey("UsuarioId");

            modelBuilder.Entity<Usuario>()
                .HasIndex(x => x.Email)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .HasIndex(x => x.Username)
                .IsUnique();
        }
    }

}
