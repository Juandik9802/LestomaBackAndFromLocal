using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Auditoria;
using LocalShared.Entities.Medicion;
using LocalWeb.Repositories;
using Microsoft.AspNetCore.Components;
using System.Net;

namespace LocalWeb.Pages.Medicion.UnidadMedida
{
    public partial class UnidadMedidaIndex
    {
        [Inject] private IRepository Repository { get; set; } = null!;
        [Inject] private SweetAlertService SweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;

        // Inicializar la lista para evitar NullReferenceException
        public List<ClsMUnidadMedida> unidadMedidas { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            await LoadAsync();
        }

        private async Task LoadAsync()
        {
            var responseHttp = await Repository.GetAsync<List<ClsMUnidadMedida>>("/api/UnidadMedida");
            if (responseHttp.Error)
            {
                var message = await responseHttp.GetErrorMessageAsync();
                await SweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                return;
            }
            unidadMedidas = responseHttp.Responce ?? new List<ClsMUnidadMedida>();
        }

        private async Task DeleteAsync(ClsMUnidadMedida unidadMedida)
        {
            var result = await SweetAlertService.FireAsync(new SweetAlertOptions
            {
                Title = "Confirmación",
                Text = $"¿Esta seguro de querer borrar: {unidadMedida.Nombre}?",
                Icon = SweetAlertIcon.Question,
                ShowCancelButton = true,
            });

            // Corregido la lógica de confirmación
            var confirm = !string.IsNullOrEmpty(result.Value);
            if (!confirm)
            {
                return;
            }

            // Corregido el tipo genérico en DeleteAsync
            var responseHttp = await Repository.DeleteAsync<ClsMAuditoria>($"/api/UnidadMedida/{unidadMedida.IdUnidadMedida}");
            if (responseHttp.Error)
            {
                if (responseHttp.HttpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                {
                    NavigationManager.NavigateTo("/UnidadMedida");
                }
                else
                {
                    var mensajeError = await responseHttp.GetErrorMessageAsync();
                    await SweetAlertService.FireAsync("Error", mensajeError, SweetAlertIcon.Error);
                }
                return;
            }

            await LoadAsync();

            var toast = SweetAlertService.Mixin(new SweetAlertOptions
            {
                Toast = true,
                Position = SweetAlertPosition.BottomEnd,
                ShowConfirmButton = true,
                Timer = 3000
            });
            await toast.FireAsync(icon: SweetAlertIcon.Success, message: "Registro Borrado con éxito");
        }
    }
}

