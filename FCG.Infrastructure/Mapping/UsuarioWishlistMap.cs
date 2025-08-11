using Microsoft.EntityFrameworkCore;
using FCG.Domain.Models;

namespace FCG.Infrastructure.Mapping
{
    public static class UsuarioWishlistMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioWishlist>(entity =>
            {
                entity.ToTable("usuario_wishlist");

                entity.HasKey(e => new { e.UsuarioId, e.JogoId });

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id");

                entity.Property(e => e.JogoId)
                    .HasColumnName("jogo_id");

                entity.HasOne(e => e.Usuario)
                    .WithMany(u => u.Wishlist)
                    .HasForeignKey(e => e.UsuarioId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Jogo)
                    .WithMany(j => j.UsuariosQueDesejam)
                    .HasForeignKey(e => e.JogoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}