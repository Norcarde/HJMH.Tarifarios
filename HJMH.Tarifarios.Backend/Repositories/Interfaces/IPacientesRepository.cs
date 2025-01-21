using HJMH.Tarifarios.Shared.Entities;
using HJMH.Tarifarios.Shared.Responses;

namespace HJMH.Tarifarios.Backend.Repositories.Interfaces
{
    /// <summary>
    /// Interface para el repositorio de Pacientes.
    /// </summary>
    public interface IPacientesRepository
    {
        /// <summary>
        /// Obtiene una lista de PacienteEmssanar basada en el documento proporcionado.
        /// </summary>
        /// <param name="documento">El documento para buscar.</param>
        /// <returns>Una tarea que representa la operación asincrónica. El resultado contiene una respuesta de acción con una enumeración de PacienteEmssanar.</returns>
        Task<ActionResponse<IEnumerable<PacienteEmssanar>>> GetPacientesEmssanarAsync(string documento);
    }
}