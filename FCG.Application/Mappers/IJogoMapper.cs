using FCG.Application.DTOs;
using FCG.Domain.Models;

namespace FCG.Application.Interfaces
{
    public interface IJogoMapper
    {
        Jogo ToEntity(JogoDTO dto);
        JogoDTO ToDto(Jogo entity);
    }
}