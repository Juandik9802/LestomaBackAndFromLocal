using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Dispositivos;
using LocalWeb.Repositories;
using LocalWeb.Shared;
using Microsoft.AspNetCore.Components;

namespace LocalWeb.Pages.Dispositivo.Dispositivo
{
    public partial class DispositivoCreate
    {
        private FormWithName<ClsMDispositivo>? DispositivoForm; // Tipo correcto
        private ClsMDispositivo? dispositivo=new();

        [Parameter] public Guid DispositivoId { get; set; }
        [Inject] private IRepository Repository { get; set; } = null!;
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;
        [Inject] private SweetAlertService SweetAlertService { get; set; } = null!;

        private async Task CreateAsync()
        {
            dispositivo.IdDispositivo = Guid.NewGuid();
            dispositivo.TipoDispositivoId = DispositivoId;

            var responseHttp = await Repository.PostAsync("/api/Dispositivo", dispositivo);
            if (responseHttp.Error)
            {
                var message = await responseHttp.GetErrorMessageAsync();
                await SweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                return;
            }
            Return();
            var toast = SweetAlertService.Mixin(new SweetAlertOptions
            {
                Toast = true,
                Position = SweetAlertPosition.BottomEnd,
                ShowConfirmButton = true,
                Timer = 3000
            });
            await toast.FireAsync(icon: SweetAlertIcon.Success, message: "Registro creado con éxito.");
        }

        private void Return()
        {
            DispositivoForm!.FormPostedSuccessfully = true;
            NavigationManager.NavigateTo($"/TipoDipositivo/details/{DispositivoId}");
        }
    }
}
