using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;
using LocalShared.Entities.Medicion;
using LocalWeb.Repositories;
using LocalWeb.Shared;
using Microsoft.AspNetCore.Components;
using System.Net;

namespace LocalWeb.Pages.Elementos.TipoElemento
{
    public partial class TipoElementoCreate
    {
        private FormWithName<ClsMTipoElemento>? TipoElementoForm; // Tipo correcto
        private ClsMTipoElemento TipoElemento = new(); // Instancia del modelo

        [Inject] private IRepository repository { get; set; } = null!;
        [Inject] private SweetAlertService sweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager navigationManager { get; set; } = null!;

        private async Task CreateAsync()
        {
            var responseHttp = await repository.PostAsync("/api/TipoElemento", TipoElemento);
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
            TipoElementoForm!.FormPostedSuccessfully = true;
            navigationManager.NavigateTo("/TipoElemento");
        }
    }
}