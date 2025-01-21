using HJMH.Tarifarios.Backend.Data;
using HJMH.Tarifarios.Backend.UnitsOfWork.Interfaces;
using HJMH.Tarifarios.Shared.Entities;
using HJMH.Tarifarios.Shared.Responses;
using Microsoft.AspNetCore.Mvc;

namespace HJMH.Tarifarios.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacientesController : ControllerBase
    {
        #region Fields

        private readonly IPacientesUnitOfWork _pacientesUnitOfWorks;
        private readonly DataContext _context;

        #endregion Fields

        #region Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="CUPSController"/>.
        /// </summary>
        /// <param name="cupsUnitOfWork">Unidad de trabajo de CUPS.</param>
        /// <param name="context">Contexto de datos.</param>
        public PacientesController(IPacientesUnitOfWork pacientesUnitOfWorks, DataContext context)
        {
            _pacientesUnitOfWorks = pacientesUnitOfWorks;
            _context = context;
        }

        #endregion Constructor

        #region Methods

        [HttpGet]
        public async Task<IActionResult> GetPacientesEmssanarAsync([FromQuery] string documento)
        {
            if (string.IsNullOrWhiteSpace(documento) || documento.Length < 6)
            {
                return BadRequest(new ActionResponse<IEnumerable<PacienteEmssanar>>
                {
                    WasSuccess = false,
                    Message = "El documento del paciente no puede estar vacío y debe tener al menos 6 caracteres."
                });
            }
            var response = await _pacientesUnitOfWorks.GetPacientesEmssanarAsync(documento);
            if (!response.WasSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        #endregion Methods
    }
}