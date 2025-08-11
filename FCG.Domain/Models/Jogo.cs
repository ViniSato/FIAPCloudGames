namespace FCG.Domain.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public DateTime? DataLancamento { get; set; }
        public int? DesenvolvedorId { get; set; }
        public required Desenvolvedor Desenvolvedor { get; set; }
        public int? PublicadoraId { get; set; }
        public required Publicadora Publicadora { get; set; }
        public int? ClassificacaoIndId { get; set; }
        public required Classificacao ClassificacaoIndicativa { get; set; }
        public required string Imagem { get; set; }
        public decimal? Preco { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? CriadoEm { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public ICollection<UsuarioWishlist> UsuariosQueDesejam { get; set; } = new List<UsuarioWishlist>();
        public ICollection<UsuarioJogo> UsuariosQuePossuem { get; set; } = new List<UsuarioJogo>();
        public ICollection<Avaliacao> AvaliacoesRecebidas { get; set; } = new List<Avaliacao>();
        public ICollection<JogoPlataforma> PlataformasDisponiveis { get; set; } = new List<JogoPlataforma>();
        public ICollection<JogoGenero> GenerosRelacionados { get; set; } = new List<JogoGenero>();
    }
}