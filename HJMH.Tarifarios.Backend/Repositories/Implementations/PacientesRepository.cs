using HJMH.Tarifarios.Backend.Data;
using HJMH.Tarifarios.Backend.Repositories.Interfaces;
using HJMH.Tarifarios.Shared.Entities;
using HJMH.Tarifarios.Shared.Responses;
using Microsoft.EntityFrameworkCore;

namespace HJMH.Tarifarios.Backend.Repositories.Implementations
{
    public class PacientesRepository : IPacientesRepository
    {
        #region Variables

        private readonly DataContext _context;

        #endregion Variables

        #region Constructor

        public PacientesRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        #endregion Constructor

        #region Métodos Públicos

        public async Task<ActionResponse<IEnumerable<PacienteEmssanar>>> GetPacientesEmssanarAsync(string documento)
        {
            if (string.IsNullOrWhiteSpace(documento))
            {
                return new ActionResponse<IEnumerable<PacienteEmssanar>>
                {
                    WasSuccess = false,
                    Message = "El documento no puede estar vacío o ser solo espacios en blanco."
                };
            }
            try
            {
                var pacientes = await (_context.PacientesEmssanar
                    .Where(s => s.NumeroIdentificacion!.Equals(documento))
                    .OrderBy(c => c.NumeroIdentificacion)
                    .ToListAsync());

                if (!pacientes.Any())
                {
                    return new ActionResponse<IEnumerable<PacienteEmssanar>>
                    {
                        WasSuccess = false,
                        Message = "No se encontraron pacientes con el documento proporcionado."
                    };
                }
                return new ActionResponse<IEnumerable<PacienteEmssanar>>
                {
                    WasSuccess = true,
                    Result = pacientes
                };
            }
            catch (Exception ex)
            {
                return new ActionResponse<IEnumerable<PacienteEmssanar>>
                {
                    WasSuccess = false,
                    Message = $"Ocurrió un error al buscar pacientes: {ex.Message}"
                };
            }
        }
    }
}

#endregion Métodos Públicos