using Microsoft.EntityFrameworkCore;
using FCG.Domain.Models;

namespace FCG.Infrastructure.Mapping
{
    public static class GeneroMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genero>(entity =>
            {
                entity.ToTable("generos");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(e => e.Ativo)
                    .HasColumnName("ativo");

                entity.Property(e => e.CriadoEm)
                    .HasColumnName("criado_em");

                entity.Property(e => e.AtualizadoEm)
                    .HasColumnName("atualizado_em");

                entity.HasMany(e => e.JogosRelacionados)
                    .WithOne(j => j.Genero)
                    .HasForeignKey(j => j.GeneroId)
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasMany(e => e.UsuariosQueGostam)
                    .WithOne(ug => ug.Genero)
                    .HasForeignKey(ug => ug.GeneroId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}