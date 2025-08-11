namespace FCG.Domain.Models
{
    public class UsuarioWishlist
    {
        public int UsuarioId { get; set; }
        public int JogoId { get; set; }
        public required Usuario Usuario { get; set; }
        public required Jogo Jogo { get; set; }
    }
}
