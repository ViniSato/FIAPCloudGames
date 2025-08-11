using Microsoft.EntityFrameworkCore;
using FCG.Domain.Models;

namespace FCG.Infrastructure.Mapping
{
    public static class AvaliadorMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avaliador>(entity =>
            {
                entity.ToTable("avaliadores");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(e => e.Imagem)
                    .HasColumnName("imagem")
                    .HasColumnType("text")
                    .IsRequired();

                entity.Property(e => e.Ativo)
                    .HasColumnName("ativo");

                entity.Property(e => e.CriadoEm)
                    .HasColumnName("criado_em");

                entity.Property(e => e.AtualizadoEm)
                    .HasColumnName("atualizado_em");

                entity.HasMany(e => e.AvaliacoesFeitas)
                    .WithOne(a => a.Avaliador)
                    .HasForeignKey(a => a.AvaliadorId)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}