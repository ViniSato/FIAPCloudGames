﻿namespace FCG.Domain.Models
{
    public class JogoGenero
    {
        public int JogoId { get; set; }
        public Jogo Jogo { get; set; } = null!;
        public int GeneroId { get; set; }
        public Genero Genero { get; set; } = null!;
    }
}