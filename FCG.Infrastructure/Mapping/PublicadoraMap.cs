using Microsoft.EntityFrameworkCore;
using FCG.Domain.Models;

namespace FCG.Infrastructure.Mapping
{
    public static class PublicadoraMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publicadora>(entity =>
            {
                entity.ToTable("publicadoras");

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

                entity.HasMany(e => e.JogosPublicados)
                    .WithOne(j => j.Publicadora)
                    .HasForeignKey(j => j.PublicadoraId)
                    .OnDelete(DeleteBehavior.SetNull);
            });
        }
    }
}