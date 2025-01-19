using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Cultivo;
using LocalShared.Entities.Tanques;
using LocalWeb.Repositories;
using Microsoft.AspNetCore.Components;
using System.Net;

namespace LocalWeb.Pages.Tanquez.Pez
{
    public partial class PezIndex
    {
        [Inject] private IRepository Repository { get; set; } = null!;
        [Inject] private SweetAlertService SweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;

        // Inicializar la lista para evitar NullReferenceException
        public List<ClsMPez> Peces { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            await LoadAsync();
        }

        private async Task LoadAsync()
        {
            var responseHttp = await Repository.GetAsync<List<ClsMPez>>("api/Pez");
            if (responseHttp.Error)
            {
                var message = await responseHttp.GetErrorMessageAsync();
                await SweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                return;
            }
            Peces = responseHttp.Responce ?? new List<ClsMPez>();
        }

        private async Task DeleteAsync(ClsMPez Pez)
        {
            var result = await SweetAlertService.FireAsync(new SweetAlertOptions
            {
                Title = "Confirmación",
                Text = $"¿Esta seguro de querer borrar eliminar la especie : {Pez.PezNombre}?",
                Icon = SweetAlertIcon.Question,
                ShowCancelButton = true,
            });

            // Corregido la lógica de confirmación
            var confirm = !string.IsNullOrEmpty(result.Value);
            if (!confirm)
            {
                return;
            }

            // Corregido el tipo genérico en DeleteAsync
            var responseHttp = await Repository.DeleteAsync<ClsMPez>($"api/Pez/{Pez.PezId}");
            if (responseHttp.Error)
            {
                if (responseHttp.HttpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                {
                    NavigationManager.NavigateTo("/Pez");
                }
                else
                {
                    var mensajeError = await responseHttp.GetErrorMessageAsync();
                    await SweetAlertService.FireAsync("Error", mensajeError, SweetAlertIcon.Error);
                }
                return;
            }

            await LoadAsync();

            var toast = SweetAlertService.Mixin(new SweetAlertOptions
            {
                Toast = true,
                Position = SweetAlertPosition.BottomEnd,
                ShowConfirmButton = true,
                Timer = 3000
            });
            await toast.FireAsync(icon: SweetAlertIcon.Success, message: "Registro Borrado con éxito");
        }
    }
}
