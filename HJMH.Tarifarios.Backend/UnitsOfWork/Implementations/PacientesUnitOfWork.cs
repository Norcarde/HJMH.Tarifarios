using HJMH.Tarifarios.Backend.Repositories.Interfaces;
using HJMH.Tarifarios.Backend.UnitsOfWork.Interfaces;
using HJMH.Tarifarios.Shared.Entities;
using HJMH.Tarifarios.Shared.Responses;

namespace HJMH.Tarifarios.Backend.UnitsOfWork.Implementations
{
    public class PacientesUnitOfWork : IPacientesUnitOfWork
    {
        private readonly IPacientesRepository _pacientesRepository;

        public PacientesUnitOfWork(IPacientesRepository pacientesRepository)
        {
            _pacientesRepository = pacientesRepository;
        }

        public async Task<ActionResponse<IEnumerable<PacienteEmssanar>>> GetPacientesEmssanarAsync(string documento) => await _pacientesRepository.GetPacientesEmssanarAsync(documento);
    }
}