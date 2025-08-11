namespace FCG.Domain.Models
{
    public class Publicadora
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Imagem { get; set; } 
        public bool? Ativo { get; set; }
        public DateTime? CriadoEm { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public ICollection<Jogo> JogosPublicados { get; set; } = new List<Jogo>();
    }
}