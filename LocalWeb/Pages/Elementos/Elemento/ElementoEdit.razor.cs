using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Medicion;
using LocalWeb.Repositories;
using LocalWeb.Shared;
using Microsoft.AspNetCore.Components;
using System.Net;

namespace LocalWeb.Pages.Elementos.Elemento
{
    public partial class ElementoEdit
    {
        private ClsMElemento? mElemento;
        private FormWithName<ClsMElemento>? ElementoForm;

        [Inject] private IRepository Repository { get; set; } = null!;
        [Inject] private SweetAlertService SweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;

        [EditorRequired, Parameter]
        public Guid Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            var responseHttp = await Repository.GetAsync<ClsMElemento>($"/api/Elemento/{Id}");
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
            mElemento = responseHttp.Responce;
        }

        private async Task SaveAsync()
        {
            var responseHttp = await Repository.PutAsync($"/api/Elemento", mElemento);
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
            ElementoForm!.FormPostedSuccessfully = true;
            NavigationManager.NavigateTo($"/Elemento/details/{mElemento!.TipoElementoId}");
        }
    }
}
