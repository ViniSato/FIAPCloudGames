namespace FCG.Domain.Models
{
    public class Plataforma
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? CriadoEm { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public ICollection<JogoPlataforma> JogosDisponiveis { get; set; } = new List<JogoPlataforma>();
    }
}