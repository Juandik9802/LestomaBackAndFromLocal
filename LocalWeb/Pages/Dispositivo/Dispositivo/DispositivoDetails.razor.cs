using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Dispositivos;
using LocalWeb.Repositories;
using Microsoft.AspNetCore.Components;
using System.Net;

namespace LocalWeb.Pages.Dispositivo.Dispositivo
{
    public partial class DispositivoDetails
    {
        public ClsMDispositivo? dispositivo;

        [Inject] private IRepository Repository { get; set; } = null!;
        [Inject] private SweetAlertService sweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager navigationManager { get; set; } = null!;

        [Parameter, EditorRequired] public Guid DispositivoId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await LoadAsync();
        }

        private async Task LoadAsync()
        {
            var responceHttp = await Repository.GetAsync < ClsMDispositivo>($"/api/Dispositivo/{DispositivoId}");
            if (responceHttp.Error)
            {
                if (responceHttp.HttpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                {
                    navigationManager.NavigateTo("/Dispositivo");
                    return;
                }

                var message = await responceHttp.GetErrorMessageAsync();
                await sweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                return;
            }
            dispositivo = responceHttp.Responce;
        }

        private async Task DeleteAsync(ClsMLogsEstado clsMLogsEstado)
        {
            var result = await sweetAlertService.FireAsync(new SweetAlertOptions
            {
                Title = "Confirmacion",
                Text = $"¿Realmente desea eliminar el registro: {clsMLogsEstado.EstadoDipositivo.Nombre}",
                Icon = SweetAlertIcon.Question,
                ShowCancelButton = true,
                CancelButtonText = "No",
                ConfirmButtonText = "Si"
            });
            var confirm = string.IsNullOrEmpty(result.Value);
            if (confirm)
            {
                return;
            }
            var responseHttp = await Repository.DeleteAsync<ClsMDispositivo>($"/api/Dispositivo/{clsMLogsEstado.IdLogsEstado}");
            if (responseHttp.Error)
            {
                if (responseHttp.HttpResponseMessage.StatusCode != HttpStatusCode.NotFound)
                {
                    var message = await responseHttp.GetErrorMessageAsync();
                    await sweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                    return;
                }
            }

            await LoadAsync();
            var toast = sweetAlertService.Mixin(new SweetAlertOptions
            {
                Toast = true,
                Position = SweetAlertPosition.BottomEnd,
                ShowConfirmButton = true,
                Timer = 3000
            });
            await toast.FireAsync(icon: SweetAlertIcon.Success, message: "Registro borrado con exito.");
        }
    }
}