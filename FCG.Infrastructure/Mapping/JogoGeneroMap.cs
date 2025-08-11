using Microsoft.EntityFrameworkCore;
using FCG.Domain.Models;

namespace FCG.Infrastructure.Mapping
{
    public static class JogoGeneroMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JogoGenero>(entity =>
            {
                entity.ToTable("jogo_genero");
                entity.HasKey(e => new { e.JogoId, e.GeneroId });

                entity.Property(e => e.JogoId)
                    .HasColumnName("jogo_id");

                entity.Property(e => e.GeneroId)
                    .HasColumnName("genero_id");

                entity.HasOne(e => e.Jogo)
                    .WithMany(j => j.GenerosRelacionados)
                    .HasForeignKey(e => e.JogoId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Genero)
                    .WithMany(g => g.JogosRelacionados)
                    .HasForeignKey(e => e.GeneroId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}