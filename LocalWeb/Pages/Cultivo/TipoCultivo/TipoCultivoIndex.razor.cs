using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Cultivo;
using LocalWeb.Repositories;
using Microsoft.AspNetCore.Components;
using System.Net;

namespace LocalWeb.Pages.Cultivo.TipoCultivo
{
    public partial class TipoCultivoIndex
    {
        [Inject] private IRepository Repository { get; set; } = null!;
        [Inject] private SweetAlertService SweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;

        // Inicializar la lista para evitar NullReferenceException
        public List<ClsMTipoCultivo> clsMTipoCultivos { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            await LoadAsync();
        }

        private async Task LoadAsync()
        {
            var responseHttp = await Repository.GetAsync<List<ClsMTipoCultivo>>("api/TipoCultivo");
            if (responseHttp.Error)
            {
                var message = await responseHttp.GetErrorMessageAsync();
                await SweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                return;
            }
            clsMTipoCultivos = responseHttp.Responce ?? new List<ClsMTipoCultivo>();
        }

        private async Task DeleteAsync(ClsMTipoCultivo clsMTipoCultivo)
        {
            var result = await SweetAlertService.FireAsync(new SweetAlertOptions
            {
                Title = "Confirmación",
                Text = $"¿Esta seguro de querer borrar la planta: {clsMTipoCultivo.TipCltNombre}?",
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
            var responseHttp = await Repository.DeleteAsync<ClsMPlantas>($"api/TipoCultivo/{clsMTipoCultivo.TipCltId}");
            if (responseHttp.Error)
            {
                if (responseHttp.HttpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                {
                    NavigationManager.NavigateTo("/TipoCultivo");
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
