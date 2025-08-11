using Microsoft.EntityFrameworkCore;
using FCG.Domain.Models;

namespace FCG.Infrastructure.Mapping
{
    internal static class AvaliacaoMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avaliacao>(entity =>
            {
                entity.ToTable("avaliacoes");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.AvaliadorId)
                    .HasColumnName("avaliador_id");

                entity.Property(e => e.AvaliadoId)
                    .HasColumnName("avaliado_id");

                entity.Property(e => e.Nota)
                    .HasColumnName("nota")
                    .HasColumnType("decimal(3,1)");

                entity.Property(e => e.AvaliacaoTexto)
                    .HasColumnName("avaliacao")
                    .HasColumnType("text");

                entity.Property(e => e.Ativo)
                    .HasColumnName("ativo");

                entity.Property(e => e.CriadoEm)
                    .HasColumnName("criado_em");

                entity.Property(e => e.AtualizadoEm)
                    .HasColumnName("atualizado_em");

                entity.HasOne(e => e.Avaliador)
                    .WithMany()
                    .HasForeignKey(e => e.AvaliadorId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.Avaliado)
                    .WithMany(j => j.AvaliacoesRecebidas)
                    .HasForeignKey(e => e.AvaliadoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}