using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Dispositivos;
using LocalWeb.Repositories;
using LocalWeb.Shared;
using Microsoft.AspNetCore.Components;

namespace LocalWeb.Pages.Dispositivo.EstadosDispositivos
{
    public partial class EstadosDispositivoCreate
    {
        private FormWithName<ClsMEstadosDispositivo>? EstadosDipositivoForm; // Tipo correcto
        private ClsMEstadosDispositivo EstadosDispositivo = new(); // Instancia del modelo

        [Inject] private IRepository repository { get; set; } = null!;
        [Inject] private SweetAlertService sweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager navigationManager { get; set; } = null!;

        private async Task CreateAsync()
        {
            EstadosDispositivo.IdEstadoDispositivo = Guid.NewGuid();
            var responseHttp = await repository.PostAsync("/api/EstadosDispositivo", EstadosDispositivo);
            if (responseHttp.Error)
            {
                var message = await responseHttp.GetErrorMessageAsync();
                await sweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                return;
            }
            Return();
            var toast = sweetAlertService.Mixin(new SweetAlertOptions
            {
                Toast = true,
                Position = SweetAlertPosition.BottomEnd,
                ShowConfirmButton = true,
                Timer = 3000
            });
            await toast.FireAsync(icon: SweetAlertIcon.Success, message: "Registro creado con exito");
        }

        private void Return()
        {
            EstadosDipositivoForm!.FormPostedSuccessfully = true;
            navigationManager.NavigateTo("/EstadosDispositivo");
        }
    }
}