using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Medicion;
using LocalWeb.Repositories;
using Microsoft.AspNetCore.Components;
using System.Net;

namespace LocalWeb.Pages.Medicion.TipoMedicion
{
    public partial class TipoMedicionDetails
    {
        public ClsMTipoMedicion? tipoMedicion;

        [Inject] private IRepository Repository { get; set; } = null!;
        [Inject] private SweetAlertService sweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager navigationManager { get; set; } = null!;

        [Parameter] public Guid TipoMedidaId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await LoadAsync();
        }

        private async Task LoadAsync()
        {
            var responceHttp = await Repository.GetAsync<ClsMTipoMedicion>($"/api/TipoMedicion/{TipoMedidaId}");
            if (responceHttp.Error)
            {
                if(responceHttp.HttpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                {
                    navigationManager.NavigateTo("/TipoMedida");
                    return;
                }

                var message = await responceHttp.GetErrorMessageAsync();
                await sweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                return;
            }
            tipoMedicion = responceHttp.Responce;
        }

        private async Task DeleteAsync(ClsMUnidadMedida clsMUnidadMedida)
        {
            var result = await sweetAlertService.FireAsync(new SweetAlertOptions
            {
                Title = "Confirmacion",
                Text = $"¿Realmente desea eliminar el Tipo de medida {clsMUnidadMedida.Nombre}",
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
            var responseHttp = await Repository.DeleteAsync<ClsMTipoMedicion>($"/api/UnidadMedida/{clsMUnidadMedida.IdUnidadMedida}");
            if (responseHttp.Error)
            {
                if(responseHttp.HttpResponseMessage.StatusCode != HttpStatusCode.NotFound)
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
