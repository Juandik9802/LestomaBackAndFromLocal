using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Cultivo;
using LocalWeb.Repositories;
using Microsoft.AspNetCore.Components;

namespace LocalWeb.Pages.Cultivo.Planta
{
    public partial class PlantasEdit
    {
        private ClsMPlantas? plantas;
        private PlantasForm plantasForm;

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
                var responseHttp = await Repository.GetAsync<ClsMPlantas>($"/api/plantas/{Id}");
                if (!responseHttp.Error)
                {
                    plantas = responseHttp.Responce;
                }
                else
                {
                    if (responseHttp.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        NavigationManager.NavigateTo("/plantas");
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
            var responseHttp = await Repository.PutAsync("api/plantas", plantas);
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
            plantasForm!.FormPostedSuccessfully = true;
            NavigationManager.NavigateTo("/Plantas");
        }
    }
}
