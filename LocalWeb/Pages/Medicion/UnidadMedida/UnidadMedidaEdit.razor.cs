using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Medicion;
using LocalWeb.Repositories;
using LocalWeb.Shared;
using Microsoft.AspNetCore.Components;
using System.Net;

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

        protected override async Task OnParametersSetAsync()
        {
            var responseHttp = await Repository.GetAsync<ClsMUnidadMedida>($"/api/UnidadMedida/{Id}");
            if (responseHttp.Error)
            {
                if (responseHttp.HttpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                {
                    Return();
                }
                var message = await responseHttp.GetErrorMessageAsync();
                await SweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                return;
            }
            unidadMedida = responseHttp.Responce;
        }

        private async Task SaveAsync()
        {
            var responseHttp = await Repository.PutAsync($"/api/UnidadMedida", unidadMedida);
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
            await toast.FireAsync(icon: SweetAlertIcon.Success, message: "Cambios guardados con exito");
        }

        private void Return()
        {
            UnidadMedidaForm!.FormPostedSuccessfully = true;
            NavigationManager.NavigateTo($"/TipoMedicion/details/{unidadMedida!.TipoMedicionId}");
        }
    }
}