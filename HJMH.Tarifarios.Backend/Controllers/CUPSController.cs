using HJMH.Tarifarios.Backend.Data;
using HJMH.Tarifarios.Backend.UnitsOfWork.Interfaces;
using HJMH.Tarifarios.Shared.Entities;
using HJMH.Tarifarios.Shared.Responses;
using Microsoft.AspNetCore.Mvc;

namespace HJMH.Tarifarios.Backend.Controllers
{
    /// <summary>
    /// Controlador para gestionar las operaciones relacionadas con CUPS.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CUPSController : ControllerBase
    {
        #region Fields

        private readonly ICUPSUnitOfWork _cupsUnitOfWork;
        private readonly DataContext _context;

        #endregion Fields

        #region Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="CUPSController"/>.
        /// </summary>
        /// <param name="cupsUnitOfWork">Unidad de trabajo de CUPS.</param>
        /// <param name="context">Contexto de datos.</param>
        public CUPSController(ICUPSUnitOfWork cupsUnitOfWork, DataContext context)
        {
            _cupsUnitOfWork = cupsUnitOfWork;
            _context = context;
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Obtiene una lista de ClasificacionUnicaProcedimientos basada en el código CUPS proporcionado.
        /// </summary>
        /// <param name="codigoCUPS">El código CUPS para buscar.</param>
        /// <returns>Una respuesta de acción con una enumeración de ClasificacionUnicaProcedimientos.</returns>
        [HttpGet]
        public async Task<IActionResult> GetCUPSAsync([FromQuery] string codigoCUPS)
        {
            if (string.IsNullOrWhiteSpace(codigoCUPS) || codigoCUPS.Length < 6)
            {
                return BadRequest(new ActionResponse<IEnumerable<ClasificacionUnicaProcedimientos>>
                {
                    WasSuccess = false,
                    Message = "El código o descripción del CUPS no puede estar vacío y debe tener al menos 6 caracteres."
                });
            }

            var response = await _cupsUnitOfWork.GetCUPSAsync(codigoCUPS);

            if (!response.WasSuccess)
            {
                return NotFound(response.Message);
            }

            return Ok(response.Result);
        }

        #endregion Methods
    }
}