using FCG.Domain.Models;

namespace FCG.Application.Interfaces
{
    public interface ILogService
    {
        Task SaveAsync(LogEntry entry);
    }
}
