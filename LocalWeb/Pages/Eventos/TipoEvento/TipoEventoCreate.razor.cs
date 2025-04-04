using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Eventos;
using LocalWeb.Repositories;
using LocalWeb.Shared;
using Microsoft.AspNetCore.Components;

namespace LocalWeb.Pages.Eventos.TipoEvento
{
    public partial class TipoEventoCreate
    {
        private FormWithName<ClsMTipoEvento>? TipoEventoForm; // Tipo correcto
        private ClsMTipoEvento TipoEvento = new(); // Instancia del modelo

        [Parameter] public Guid Id { get; set; }
        [Inject] private IRepository repository { get; set; } = null!;
        [Inject] private SweetAlertService sweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager navigationManager { get; set; } = null!;

        private async Task CreateAsync()
        {
            TipoEvento.IdTipoEvento= Guid.NewGuid();
            TipoEvento.ImpactoId = Id;
            var responseHttp = await repository.PostAsync("/api/TipoEvento", TipoEvento);
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
            TipoEventoForm!.FormPostedSuccessfully = true;
            navigationManager.NavigateTo("/TipoMedicion");
        }
    }
}
