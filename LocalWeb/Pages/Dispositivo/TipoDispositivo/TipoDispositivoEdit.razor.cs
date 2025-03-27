using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Dispositivos;
using LocalWeb.Repositories;
using LocalWeb.Shared;
using Microsoft.AspNetCore.Components;

namespace LocalWeb.Pages.Dispositivo.TipoDispositivo
{
    public partial class TipoDispositivoEdit
    {
        private ClsMTipoDispositivo? TipoDispositivo;
        private FormWithName<ClsMTipoDispositivo>? MarcaForm;

        [Inject] private IRepository Repository { get; set; } = null!;
        [Inject] private SweetAlertService SweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;

        [EditorRequired, Parameter]
        public Guid Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            try
            {
                var responseHttp = await Repository.GetAsync<ClsMTipoDispositivo>($"/api/TipoDispositivo/{Id}");
                if (!responseHttp.Error)
                {
                    TipoDispositivo = responseHttp.Responce;
                }
                else
                {
                    if (responseHttp.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        NavigationManager.NavigateTo("/TipoDispositivo");
                    }
                    else
                    {
                        var message = await responseHttp.GetErrorMessageAsync();
                        await SweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                await SweetAlertService.FireAsync("Error", $"Excepción: {ex.Message}", SweetAlertIcon.Error);
            }
        }

        private async Task EditAsync()
        {
            var responseHttp = await Repository.PutAsync("api/TipoDispositivo", TipoDispositivo);
            if (responseHttp.Error)
            {
                var message = await responseHttp.GetErrorMessageAsync();
                await SweetAlertService.FireAsync("Error", message);
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
            await toast.FireAsync(icon: SweetAlertIcon.Success, message: "Cambios guardados con éxito");
        }

        private void Return()
        {
            MarcaForm!.FormPostedSuccessfully = true;
            NavigationManager.NavigateTo("/TipoDispositivo");
        }
    }
}    