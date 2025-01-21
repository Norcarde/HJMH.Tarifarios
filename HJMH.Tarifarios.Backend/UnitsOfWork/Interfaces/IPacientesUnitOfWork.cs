using HJMH.Tarifarios.Shared.Entities;
using HJMH.Tarifarios.Shared.Responses;

namespace HJMH.Tarifarios.Backend.UnitsOfWork.Interfaces
{
    public interface IPacientesUnitOfWork
    {
        Task<ActionResponse<IEnumerable<PacienteEmssanar>>> GetPacientesEmssanarAsync(string documento);
    }
}