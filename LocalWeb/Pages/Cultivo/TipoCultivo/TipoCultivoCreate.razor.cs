using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Cultivo;
using LocalWeb.Pages.Cultivo.Planta;
using LocalWeb.Repositories;
using Microsoft.AspNetCore.Components;

namespace LocalWeb.Pages.Cultivo.TipoCultivo
{
    public partial class TipoCultivoCreate
    {
        private ClsMTipoCultivo TipoCultivo = new();
        private TipoCultivoForm? TipoCultivoForm;

        [Inject] private IRepository repository { get; set; } = null!;
        [Inject] private SweetAlertService sweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager navigationManager { get; set; } = null!;

        private async Task CreateAsync()
        {
            var responseHttp = await repository.PostAsync("api/TipoCultivo", TipoCultivo);
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
            TipoCultivoForm!.FormPostedSuccessfully = true;
            navigationManager.NavigateTo("/Plantas");
        }
    }
}
