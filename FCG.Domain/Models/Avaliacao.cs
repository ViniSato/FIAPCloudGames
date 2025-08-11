namespace FCG.Domain.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int? AvaliadorId { get; set; }
        public required Avaliador Avaliador { get; set; }
        public int? AvaliadoId { get; set; }
        public required Jogo Avaliado { get; set; }
        public decimal? Nota { get; set; } 
        public required string AvaliacaoTexto { get; set; } 
        public bool? Ativo { get; set; }
        public DateTime? CriadoEm { get; set; }
        public DateTime? AtualizadoEm { get; set; }
    }
}