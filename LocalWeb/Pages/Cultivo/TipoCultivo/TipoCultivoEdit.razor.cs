using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Cultivo;
using LocalWeb.Repositories;
using Microsoft.AspNetCore.Components;

namespace LocalWeb.Pages.Cultivo.TipoCultivo
{
    public partial class TipoCultivoEdit
    {
        ClsMTipoCultivo? TipoCultivo;
        private TipoCultivoForm TipoCultivoForm;

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
                var responseHttp = await Repository.GetAsync<ClsMTipoCultivo>($"/api/TipoCultivo/{Id}");
                if (!responseHttp.Error)
                {
                    TipoCultivo = responseHttp.Responce;
                }
                else
                {
                    if (responseHttp.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        NavigationManager.NavigateTo("/TipoCultivo");
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
            var responseHttp = await Repository.PutAsync("api/TipoCultivo", TipoCultivo);
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
            TipoCultivoForm!.FormPostedSuccessfully = true;
            NavigationManager.NavigateTo("/TipoCultivo");
        }
    }
}
