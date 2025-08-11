namespace FCG.Domain.Models
{
    public class UsuarioGeneroFav
    {
        public int UsuarioId { get; set; }
        public int GeneroId { get; set; }
        public required Usuario Usuario { get; set; }
        public required Genero Genero { get; set; }
    }
}
