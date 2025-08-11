using Microsoft.EntityFrameworkCore;
using FCG.Domain.Models;

namespace FCG.Infrastructure.Mapping
{
    public static class JogoPlataformaMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JogoPlataforma>(entity =>
            {
                entity.ToTable("jogo_plataforma");

                entity.HasKey(e => new { e.JogoId, e.PlataformaId });

                entity.Property(e => e.JogoId)
                    .HasColumnName("jogo_id");

                entity.Property(e => e.PlataformaId)
                    .HasColumnName("plataforma_id");

                entity.HasOne(e => e.Jogo)
                    .WithMany(j => j.PlataformasDisponiveis)
                    .HasForeignKey(e => e.JogoId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Plataforma)
                    .WithMany(p => p.JogosDisponiveis)
                    .HasForeignKey(e => e.PlataformaId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}