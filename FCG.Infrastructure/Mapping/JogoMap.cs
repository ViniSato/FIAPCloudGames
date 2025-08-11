using Microsoft.EntityFrameworkCore;
using FCG.Domain.Models;

namespace FCG.Infrastructure.Mapping
{
    internal static class JogoMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogo>()
                .ToTable("jogos");

            modelBuilder.Entity<Jogo>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Jogo>()
                .Property(x => x.Id)
                .HasColumnName("id");

            modelBuilder.Entity<Jogo>()
                .Property(x => x.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");

            modelBuilder.Entity<Jogo>()
                .Property(x => x.Descricao)
                .HasColumnName("descricao");

            modelBuilder.Entity<Jogo>()
                .Property(x => x.DataLancamento)
                .HasColumnName("data_lancamento");

            modelBuilder.Entity<Jogo>()
                .Property(x => x.DesenvolvedorId)
                .HasColumnName("desenvolvedor_id");

            modelBuilder.Entity<Jogo>()
                .Property(x => x.PublicadoraId)
                .HasColumnName("publicadora_id");

            modelBuilder.Entity<Jogo>()
                .Property(x => x.ClassificacaoIndId)
                .HasColumnName("classificacao_ind_id");

            modelBuilder.Entity<Jogo>()
                .Property(x => x.Imagem)
                .HasColumnName("imagem");

            modelBuilder.Entity<Jogo>()
                .Property(x => x.Preco)
                .HasColumnType("decimal(10,2)")
                .HasColumnName("preco");

            modelBuilder.Entity<Jogo>()
                .Property(x => x.Ativo)
                .HasColumnName("ativo");

            modelBuilder.Entity<Jogo>()
                .Property(x => x.CriadoEm)
                .HasColumnName("criado_em");

            modelBuilder.Entity<Jogo>()
                .Property(x => x.AtualizadoEm)
                .HasColumnName("atualizado_em");

            modelBuilder.Entity<Jogo>()
                .HasOne(x => x.Desenvolvedor)
                .WithMany()
                .HasForeignKey(x => x.DesenvolvedorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Jogo>()
                .HasOne(x => x.Publicadora)
                .WithMany()
                .HasForeignKey(x => x.PublicadoraId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Jogo>()
                .HasOne(x => x.ClassificacaoIndicativa)
                .WithMany()
                .HasForeignKey(x => x.ClassificacaoIndId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Jogo>()
                .HasMany(x => x.UsuariosQueDesejam)
                .WithOne(x => x.Jogo)
                .HasForeignKey(x => x.JogoId);

            modelBuilder.Entity<Jogo>()
                .HasMany(x => x.UsuariosQuePossuem)
                .WithOne(x => x.Jogo)
                .HasForeignKey(x => x.JogoId);

            modelBuilder.Entity<Jogo>()
                .HasMany(x => x.AvaliacoesRecebidas)
                .WithOne(x => x.Avaliado)
                .HasForeignKey(x => x.AvaliadoId);

            modelBuilder.Entity<Jogo>()
                .HasMany(x => x.PlataformasDisponiveis)
                .WithOne(x => x.Jogo)
                .HasForeignKey(x => x.JogoId);
        }
    }
}