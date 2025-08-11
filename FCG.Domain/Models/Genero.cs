namespace FCG.Domain.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? CriadoEm { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public ICollection<JogoGenero> JogosRelacionados { get; set; } = new List<JogoGenero>();
        public ICollection<UsuarioGeneroFav> UsuariosQueGostam { get; set; } = new List<UsuarioGeneroFav>();
    }
}