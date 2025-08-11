using FCG.Application.DTOs;
using FCG.Application.Interfaces;
using FCG.Domain.Models;

namespace FCG.Application.Mappers
{
    public class UsuarioMapper : IUsuarioMapper
    {
        public Usuario ToEntity(UsuarioDTO dto)
        {
            return new Usuario
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Email = dto.Email,
                SenhaHash = dto.SenhaHash,
                CriadoEm = dto.CriadoEm
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
                CriadoEm = usuario.CriadoEm
            };
        }
    }
}