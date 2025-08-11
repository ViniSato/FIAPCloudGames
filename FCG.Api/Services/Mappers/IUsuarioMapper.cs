using FCG.Api.Models.Requests;
using FCG.Api.Models.Responses;
using FCG.Application.DTOs;
using FCG.Domain.Models;

namespace FCG.Api.Services.Mappers
{
    public interface IUsuarioMapper
    {
        UsuarioDTO ToDto(UsuarioRequest request);
        UsuarioResponse ToResponse(UsuarioDTO dto);
        UsuarioDTO ToDto(Usuario usuario);
        Usuario ToEntity(UsuarioDTO dto);

    }
}