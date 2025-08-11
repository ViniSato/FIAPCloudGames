using FCG.Application.DTOs;

namespace FCG.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task CreateUsuarioAsync(UsuarioDTO request);
        Task UpdateUsuarioAsync(UsuarioDTO request);
        Task<bool> DeleteUsuarioAsync(int id);
        Task<UsuarioDTO> GetUsuarioByIdAsync(int id);
    }
}
