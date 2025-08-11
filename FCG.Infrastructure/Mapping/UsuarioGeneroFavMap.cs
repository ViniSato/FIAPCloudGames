using Microsoft.EntityFrameworkCore;
using FCG.Domain.Models;

namespace FCG.Infrastructure.Mapping
{
    public static class UsuarioGeneroFavMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioGeneroFav>(entity =>
            {
                entity.ToTable("usuario_genero_fav");

                entity.HasKey(e => new { e.UsuarioId, e.GeneroId });

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id");

                entity.Property(e => e.GeneroId)
                    .HasColumnName("genero_id");

                entity.HasOne(e => e.Usuario)
                    .WithMany(u => u.GenerosFavoritos)
                    .HasForeignKey(e => e.UsuarioId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Genero)
                    .WithMany(g => g.UsuariosQueGostam)
                    .HasForeignKey(e => e.GeneroId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}