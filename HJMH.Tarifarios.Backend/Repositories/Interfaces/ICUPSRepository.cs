using HJMH.Tarifarios.Shared.Entities;
using HJMH.Tarifarios.Shared.Responses;

namespace HJMH.Tarifarios.Backend.Repositories.Interfaces
{
    /// <summary>
    /// Interface para el repositorio de CUPS.
    /// </summary>
    public interface ICUPSRepository
    {
        /// <summary>
        /// Obtiene una lista de ClasificacionUnicaProcedimientos basada en el código CUPS proporcionado.
        /// </summary>
        /// <param name="codigoCUPS">El código CUPS para buscar.</param>
        /// <returns>Una tarea que representa la operación asincrónica. El resultado contiene una respuesta de acción con una enumeración de ClasificacionUnicaProcedimientos.</returns>
        Task<ActionResponse<IEnumerable<ClasificacionUnicaProcedimientos>>> GetCUPSAsync(string codigoCUPS);

        /// <summary>
        /// Obtiene una lista de Homologado basada en el código CUPS proporcionado.
        /// </summary>
        /// <param name="codigoCUPS">El código CUPS para buscar.</param>
        /// <returns>Una tarea que representa la operación asincrónica. El resultado contiene una respuesta de acción con una enumeración de Homologado.</returns>
        Task<ActionResponse<IEnumerable<Homologado>>> GetCupsHomologadorAsync(string codigoCUPS);
    }
}