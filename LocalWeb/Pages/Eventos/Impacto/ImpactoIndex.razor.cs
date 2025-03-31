using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Eventos;
using LocalWeb.Repositories;
using Microsoft.AspNetCore.Components;
using System.Net;

namespace LocalWeb.Pages.Eventos.Impacto
{
    public partial class ImpactoIndex
    {
        [Inject] private IRepository Repository { get; set; } = null!;
        [Inject] private SweetAlertService SweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;

        // Inicializar la lista para evitar NullReferenceException
        public List<ClsMImpacto> Impactos { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            await LoadAsync();
        }

        private async Task LoadAsync()
        {
            var responseHttp = await Repository.GetAsync<List<ClsMImpacto>>("/api/Impacto");
            if (responseHttp.Error)
            {
                var message = await responseHttp.GetErrorMessageAsync();
                await SweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                return;
            }
            Impactos = responseHttp.Responce ?? new List<ClsMImpacto>();
        }

        private async Task DeleteAsync(ClsMImpacto impacto)
        {
            var result = await SweetAlertService.FireAsync(new SweetAlertOptions
            {
                Title = "Confirmación",
                Text = $"¿Esta seguro de querer borrar: {impacto.Nombre}?",
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
            var responseHttp = await Repository.DeleteAsync<ClsMImpacto>($"/api/Impacto/{impacto.IdImpacto}");
            if (responseHttp.Error)
            {
                if (responseHttp.HttpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                {
                    NavigationManager.NavigateTo("/Evento");
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
