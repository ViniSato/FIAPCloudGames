using FCG.Api.Models.Requests;
using FCG.Api.Models.Responses;
using FCG.Application.DTOs;
using FCG.Domain.Models;

namespace FCG.Api.Services.Mappers
{
    public interface IJogoMapper
    {
        JogoDTO ToDto(JogoRequest request);
        JogoResponse ToResponse(JogoDTO dto);
    }
}
