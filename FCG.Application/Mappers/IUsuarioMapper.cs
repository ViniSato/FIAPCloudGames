using FCG.Application.DTOs;
using FCG.Domain.Models;

namespace FCG.Application.Interfaces
{
    public interface IUsuarioMapper
    {
        Usuario ToEntity(UsuarioDTO dto);
        UsuarioDTO ToDto(Usuario usuario);
    }
}