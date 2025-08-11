using Microsoft.EntityFrameworkCore;
using FCG.Domain.Models;

namespace FCG.Infrastructure.Mapping
{
    public static class PlataformaMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plataforma>(entity =>
            {
                entity.ToTable("plataformas");

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

                entity.HasMany(e => e.JogosDisponiveis)
                    .WithOne(jp => jp.Plataforma)
                    .HasForeignKey(jp => jp.PlataformaId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}