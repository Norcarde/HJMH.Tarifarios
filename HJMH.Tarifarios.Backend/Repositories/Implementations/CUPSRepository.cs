using HJMH.Tarifarios.Backend.Data;
using HJMH.Tarifarios.Backend.Repositories.Interfaces;
using HJMH.Tarifarios.Shared.Entities;
using HJMH.Tarifarios.Shared.Responses;
using Microsoft.EntityFrameworkCore;

namespace HJMH.Tarifarios.Backend.Repositories.Implementations
{
    /// <summary>
    /// Repositorio para manejar operaciones relacionadas con CUPS.
    /// </summary>
    public class CUPSRepository : ICUPSRepository
    {
        #region Variables

        private readonly DataContext _context;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="CUPSRepository"/>.
        /// </summary>
        /// <param name="context">El contexto de datos.</param>
        public CUPSRepository(DataContext context)
        {
            _context = context;
        }

        #endregion Constructor

        #region Métodos Públicos

        /// <summary>
        /// Obtiene una lista de ClasificacionUnicaProcedimientos basada en el código CUPS proporcionado.
        /// </summary>
        /// <param name="codigoCUPS">El código CUPS para buscar.</param>
        /// <returns>Una tarea que representa la operación asincrónica. El resultado contiene una respuesta de acción con una enumeración de ClasificacionUnicaProcedimientos.</returns>
        public async Task<ActionResponse<IEnumerable<ClasificacionUnicaProcedimientos>>> GetCUPSAsync(string codigoCUPS)
        {
            if (string.IsNullOrWhiteSpace(codigoCUPS))
            {
                return new ActionResponse<IEnumerable<ClasificacionUnicaProcedimientos>>
                {
                    WasSuccess = false,
                    Message = "El código CUPS no puede estar vacío o ser solo espacios en blanco."
                };
            }

            try
            {
                var cups = await _context.CUPS
                    .Where(s => EF.Functions.Like(s.CUPS, $"%{codigoCUPS}%") ||
                                (s.Descripcion != null && EF.Functions.Like(s.Descripcion, $"%{codigoCUPS}%")))
                    .OrderBy(c => c.Id)
                    .ToListAsync();

                if (!cups.Any())
                {
                    return new ActionResponse<IEnumerable<ClasificacionUnicaProcedimientos>>
                    {
                        WasSuccess = false,
                        Message = "No se encontraron registros de CUPS con el código proporcionado."
                    };
                }

                return new ActionResponse<IEnumerable<ClasificacionUnicaProcedimientos>>
                {
                    WasSuccess = true,
                    Result = cups
                };
            }
            catch (DbUpdateException ex)
            {
                return new ActionResponse<IEnumerable<ClasificacionUnicaProcedimientos>>
                {
                    WasSuccess = false,
                    Message = $"Error al actualizar la base de datos: {ex.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ActionResponse<IEnumerable<ClasificacionUnicaProcedimientos>>
                {
                    WasSuccess = false,
                    Message = $"Ocurrió un error al obtener los datos: {ex.Message}"
                };
            }
        }

        /// <returns>Una tarea que representa la operación asincrónica. El resultado contiene una respuesta de acción con una enumeración de Homologado.</returns>
        public async Task<ActionResponse<IEnumerable<Homologado>>> GetCupsHomologadorAsync(string codigoCups)
        {
            if (string.IsNullOrWhiteSpace(codigoCups))
            {
                return new ActionResponse<IEnumerable<Homologado>>
                {
                    WasSuccess = false,
                    Message = "El código CUPS no puede estar vacío o ser solo espacios en blanco."
                };
            }

            try
            {
                var homologador = await (from c in _context.CUPS
                                         join h in _context.Homologados on c.Id equals h.CupsId into homologadorGroup
                                         from h in homologadorGroup.DefaultIfEmpty()
                                         join s in _context.Soat on h.SoatId equals s.Id into soatGroup
                                         from s in soatGroup.DefaultIfEmpty()
                                         where c.CUPS == codigoCups
                                         select new Homologado
                                         {
                                             CupsId = c.Id,
                                             Cups = c,
                                             SoatId = s.Id,
                                             Soat = s
                                         }).ToListAsync();

                if (!homologador.Any())
                {
                    return new ActionResponse<IEnumerable<Homologado>>
                    {
                        WasSuccess = false,
                        Message = "No se encontraron registros de CUPS con el código proporcionado."
                    };
                }

                return new ActionResponse<IEnumerable<Homologado>>
                {
                    WasSuccess = true,
                    Result = homologador
                };
            }
            catch (Exception ex)
            {
                return new ActionResponse<IEnumerable<Homologado>>
                {
                    WasSuccess = false,
                    Message = $"Ocurrió un error al intentar obtener los registros de homologación: {ex.Message}"
                };
            }
        }

        #endregion Métodos Públicos
    }
}