﻿using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Auditoria;
using LocalWeb.Repositories;
using Microsoft.AspNetCore.Components;

namespace LocalWeb.Pages.Auditoria
{
    public partial class AuditoriaCreate
    {
        private ClsMAuditoria Auditoria = new();
        private AuditoriaForm? AuditoriaForm;

        [Inject] private IRepository repository { get; set; } = null!;
        [Inject] private SweetAlertService sweetAlertService { get; set; } = null!;
        [Inject] private NavigationManager navigationManager { get; set; } = null!;

        private async Task CreateAsync()
        {
            var responseHttp = await repository.PostAsync("api/Auditoria", Auditoria);
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
            AuditoriaForm!.FormPostedSuccessfully = true;
            navigationManager.NavigateTo("/Auditoria");
        }
    }
}
