using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Medicion;
using LocalWeb.Repositories;
using LocalWeb.Shared;
using Microsoft.AspNetCore.Components;

namespace LocalWeb.Pages.Medicion.UnidadMedida
{
    public partial class UnidadMedidaEdit
    {
        private ClsMUnidadMedida? unidadMedida;
        private FormWithName<ClsMUnidadMedida>? UnidadMedidaForm;

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
                var responseHttp = await Repository.GetAsync<ClsMUnidadMedida>($"/api/UnidadMedida/{Id}");
                if (!responseHttp.Error)
                {
                    unidadMedida = responseHttp.Responce;
                }
                else
                {
                    if (responseHttp.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        NavigationManager.NavigateTo("/UnidadMedida");
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
            var responseHttp = await Repository.PutAsync("api/UnidadMedida", unidadMedida);
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
            UnidadMedidaForm!.FormPostedSuccessfully = true;
            NavigationManager.NavigateTo("/UnidadMedida");
        }
    }
}