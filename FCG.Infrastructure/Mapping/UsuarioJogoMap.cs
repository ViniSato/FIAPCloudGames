using Microsoft.EntityFrameworkCore;
using FCG.Domain.Models;

namespace FCG.Infrastructure.Mapping
{
    public static class UsuarioJogoMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioJogo>(entity =>
            {
                entity.ToTable("usuario_jogo");

                entity.HasKey(e => new { e.UsuarioId, e.JogoId });

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id");

                entity.Property(e => e.JogoId)
                    .HasColumnName("jogo_id");

                entity.HasOne(e => e.Usuario)
                    .WithMany(u => u.Jogos)
                    .HasForeignKey(e => e.UsuarioId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Jogo)
                    .WithMany(j => j.UsuariosQuePossuem)
                    .HasForeignKey(e => e.JogoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}