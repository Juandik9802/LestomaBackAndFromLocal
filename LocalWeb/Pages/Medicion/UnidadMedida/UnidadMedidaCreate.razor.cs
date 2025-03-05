using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Medicion;
using LocalWeb.Repositories;
using LocalWeb.Shared;
using Microsoft.AspNetCore.Components;

namespace LocalWeb.Pages.Medicion.UnidadMedida
{
    public partial class UnidadMedidaCreate
    {
        private FormWithName<ClsMUnidadMedida>? UnidadMedidaForm; // Tipo correcto
        private ClsMUnidadMedida unidadMedida = new(); // Instancia del modelo

        [Parameter] public Guid TipoMedidaId { get; set; }
        [Inject] private IRepository repository { get; set; } = null!;
        [Inject] private SweetAlertService sweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager navigationManager { get; set; } = null!;

        private async Task CreateAsync()
        {
            unidadMedida.IdUnidadMedida = Guid.NewGuid();
            unidadMedida.TipoMedicionId= TipoMedidaId;

            var responseHttp = await repository.PostAsync("/api/UnidadMedida", unidadMedida);
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
            UnidadMedidaForm!.FormPostedSuccessfully = true;
            navigationManager.NavigateTo("/TipoMedicion");
        }
    }
}