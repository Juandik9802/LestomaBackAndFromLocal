//using CurrieTechnologies.Razor.SweetAlert2;
//using LocalShared.Entities.Dispositivos;
//using LocalWeb.Repositories;
//using LocalWeb.Shared;
//using Microsoft.AspNetCore.Components;

//namespace LocalWeb.Pages.LogsDipositivo
//{
//    public partial class LogsDispositivoCreate
//    {
//        private FormWithName<ClsMLogsEstado>? MarcaForm; // Tipo correcto
//        private ClsMDispositivo Dispositivo = new(); // Instancia del modelo

//        [Inject] private IRepository repository { get; set; } = null!;
//        [Inject] private SweetAlertService sweetAlertService { get; set; } = null!;
//        [Inject] private NavigationManager navigationManager { get; set; } = null!;

//        private async Task CreateAsync()
//        {
//            var responseHttp = await repository.PostAsync("/api/Dispositivo", Dispositivo);
//            if (responseHttp.Error)
//            {
//                var message = await responseHttp.GetErrorMessageAsync();
//                await sweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
//                return;
//            }
//            Return();
//            var toast = sweetAlertService.Mixin(new SweetAlertOptions
//            {
//                Toast = true,
//                Position = SweetAlertPosition.BottomEnd,
//                ShowConfirmButton = true,
//                Timer = 3000
//            });
//            await toast.FireAsync(icon: SweetAlertIcon.Success, message: "Registro creado con exito");
//        }

//        private void Return()
//        {
//            MarcaForm!.FormPostedSuccessfully = true;
//            navigationManager.NavigateTo("/TipoDispositivo");
//        }
//    }
//}