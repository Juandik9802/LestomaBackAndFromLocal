using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Elementos;
using LocalWeb.Repositories;
using LocalWeb.Shared;
using Microsoft.AspNetCore.Components;

namespace LocalWeb.Pages.Elementos.Elemento
{
    public partial class ElementoCreate
    {
        private FormWithName<ClsMElemento>? ElementoForm;  //Tipo correcto
        private ClsMElemento MElemento = new(); // Instancia del modelo

        [Parameter] public Guid Id { get; set; }
        [Inject] private IRepository repository { get; set; } = null!;
        [Inject] private SweetAlertService sweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager navigationManager { get; set; } = null!;

        private async Task CreateAsync()
        {
            MElemento.IdElemento = Guid.NewGuid();
            MElemento.TipoElementoId = Id;

            var responseHttp = await repository.PostAsync("/api/Elemento", MElemento);
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
            ElementoForm!.FormPostedSuccessfully = true;
            navigationManager.NavigateTo($"/Elemento/details/{MElemento.TipoElementoId}");
        }
    }
}