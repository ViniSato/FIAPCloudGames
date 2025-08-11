namespace FCG.Domain.Models
{
    public class JogoPlataforma
    {
        public int JogoId { get; set; }
        public int PlataformaId { get; set; }
        public required Jogo Jogo { get; set; }
        public required Plataforma Plataforma { get; set; }
    }
}
