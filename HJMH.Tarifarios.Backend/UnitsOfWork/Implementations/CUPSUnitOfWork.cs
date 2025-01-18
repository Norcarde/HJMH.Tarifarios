using HJMH.Tarifarios.Backend.Repositories.Interfaces;
using HJMH.Tarifarios.Backend.UnitsOfWork.Interfaces;
using HJMH.Tarifarios.Shared.Entities;
using HJMH.Tarifarios.Shared.Responses;

namespace HJMH.Tarifarios.Backend.UnitsOfWork.Implementations
{
    /// <summary>
    /// Unidad de trabajo para CUPS.
    /// </summary>
    public class CUPSUnitOfWork : ICUPSUnitOfWork
    {
        private readonly ICUPSRepository _cupsRepository;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="CUPSUnitOfWork"/>.
        /// </summary>
        /// <param name="cupsRepository">El repositorio de CUPS.</param>
        public CUPSUnitOfWork(ICUPSRepository cupsRepository)
        {
            _cupsRepository = cupsRepository;
        }

        /// <summary>
        /// Obtiene una lista de ClasificacionUnicaProcedimientos basada en el código CUPS proporcionado.
        /// </summary>
        /// <param name="codigoCUPS">El código CUPS para buscar.</param>
        /// <returns>Una tarea que representa la operación asincrónica. El resultado contiene una respuesta de acción con una enumeración de ClasificacionUnicaProcedimientos.</returns>
        public async Task<ActionResponse<IEnumerable<ClasificacionUnicaProcedimientos>>> GetCUPSAsync(string codigoCUPS) => await _cupsRepository.GetCUPSAsync(codigoCUPS);
    }
}