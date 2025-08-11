namespace FCG.Domain.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Username { get; set; }
        public int? Idade { get; set; }
        public required string Pais { get; set; }
        public char? Sexo { get; set; }
        public required string SenhaHash { get; set; }
        public required string Imagem { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? CriadoEm { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public required string Nivel { get; set; }
        public ICollection<UsuarioGeneroFav> GenerosFavoritos { get; set; } = new List<UsuarioGeneroFav>();
        public ICollection<UsuarioWishlist> Wishlist { get; set; } = new List<UsuarioWishlist>();
        public ICollection<UsuarioJogo> Jogos { get; set; } = new List<UsuarioJogo>();
    }
}