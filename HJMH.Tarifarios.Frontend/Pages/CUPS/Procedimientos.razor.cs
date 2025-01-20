using CurrieTechnologies.Razor.SweetAlert2;
using HJMH.Tarifarios.Frontend.Repositories;
using HJMH.Tarifarios.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace HJMH.Tarifarios.Frontend.Pages.CUPS
{
    /// <summary>
    /// Clase parcial para la p�gina de procedimientos.
    /// </summary>
    public partial class Procedimientos
    {
        #region Inyecciones

        /// <summary>
        /// Servicio de JavaScript para invocar funciones de JavaScript desde C#.
        /// </summary>
        [Inject] private IJSRuntime JSRuntime { get; set; } = null!;

        /// <summary>
        /// Servicio de navegaci�n para redirigir entre p�ginas.
        /// </summary>
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;

        /// <summary>
        /// Servicio de alertas para mostrar mensajes al usuario.
        /// </summary>
        [Inject] private SweetAlertService SweetAlertService { get; set; } = null!;

        /// <summary>
        /// Repositorio para acceso a datos de procedimientos.
        /// </summary>
        [Inject] private IRepository Repository { get; set; } = null!;

        #endregion Inyecciones

        #region Variables

        /// <summary>
        /// Lista de procedimientos obtenidos desde el repositorio.
        /// </summary>
        public List<ClasificacionUnicaProcedimientos> CUPs { get; set; } = new List<ClasificacionUnicaProcedimientos>();

        /// <summary>
        /// Texto ingresado por el usuario para buscar procedimientos.
        /// </summary>
        public string SearchText { get; set; } = string.Empty;

        #endregion Variables

        #region Metodos

        /// <summary>
        /// Maneja el evento de presionar una tecla en el campo de b�squeda.
        /// Si la tecla presionada es "Enter" o "NumpadEnter", se ejecuta la b�squeda.
        /// </summary>
        /// <param name="e">Argumentos del evento de teclado.</param>
        private async Task HandleKeyDown(KeyboardEventArgs e)
        {
            if (e.Key == "Enter" || e.Key == "NumpadEnter")
            {
                // Llamar al m�todo para cargar los procedimientos seg�n el texto de b�squeda.
                await LoadCups();
            }
        }

        /// <summary>
        /// Carga los procedimientos desde el repositorio seg�n el texto de b�squeda.
        /// </summary>
        public async Task LoadCups()
        {
            if (string.IsNullOrWhiteSpace(SearchText) || SearchText.Length < 6)
            {
                await SweetAlertService.FireAsync("Error", "El texto de b�squeda debe contener al menos 6 caracteres.", SweetAlertIcon.Error);
                return;
            }

            try
            {
                var response = await Repository.GetAsync<List<ClasificacionUnicaProcedimientos>>($"/api/CUPS?codigoCUPS={SearchText}");
                if (response.Error)
                {
                    var message = await response.GetErrorMessageAsync();
                    await SweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                }
                else
                {
                    CUPs = response.Response ?? new List<ClasificacionUnicaProcedimientos>();
                }
            }
            catch (Exception ex)
            {
                await SweetAlertService.FireAsync("Error", $"Ocurri� un error inesperado: {ex.Message}", SweetAlertIcon.Error);
            }
        }

        #endregion Metodos
    }
}