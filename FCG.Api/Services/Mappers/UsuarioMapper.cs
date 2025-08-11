using FCG.Api.Models.Requests;
using FCG.Api.Models.Responses;
using FCG.Application.DTOs;
using FCG.Domain.Models;

namespace FCG.Api.Services.Mappers
{
    public class UsuarioMapper : IUsuarioMapper
    {
        public UsuarioDTO ToDto(UsuarioRequest request)
        {
            return new UsuarioDTO
            {
                Nome = request.Nome,
                Email = request.Email,
                SenhaHash = request.Senha,
                Papel = request.Papel,
                CriadoEm = DateTime.UtcNow
            };
        }

        public UsuarioResponse ToResponse(UsuarioDTO dto)
        {
            return new UsuarioResponse
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Email = dto.Email,
                Papel = dto.Papel,
                CriadoEm = dto.CriadoEm,
                AtualizadoEm = dto.AtualizadoEm
            };
        }

        public UsuarioDTO ToDto(Usuario usuario)
        {
            return new UsuarioDTO
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Email = usuario.Email,
                SenhaHash = usuario.SenhaHash,
                Papel = usuario.Papel,
                CriadoEm = usuario.CriadoEm,
                AtualizadoEm = usuario.AtualizadoEm
            };
        }

        public Usuario ToEntity(UsuarioDTO dto)
        {
            return new Usuario
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Email = dto.Email,
                SenhaHash = dto.SenhaHash,
                Papel = dto.Papel,
                CriadoEm = dto.CriadoEm,
                AtualizadoEm = dto.AtualizadoEm
            };
        }
    }

}
