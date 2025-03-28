using Microsoft.AspNetCore.Components;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.JSInterop;

namespace LocalWeb.Pages
{
    public partial class Home
    {
        [Inject]
        private SweetAlertService SweetAlertService { get; set; } = null!;

        [Inject]
        private IJSRuntime JsRuntime { get; set; } = null!;

        private async Task IniciarSesion()
        {
            var result = await SweetAlertService.FireAsync(new SweetAlertOptions
            {
                Title = "Iniciar Sesión",
                Html = @"
                    <input type='text' id='swal-input-usuario' class='swal2-input' placeholder='Usuario'>
                    <input type='password' id='swal-input-password' class='swal2-input' placeholder='Contraseña'>
                ",
                ShowCancelButton = true,
                ConfirmButtonText = "Iniciar Sesión",
                CancelButtonText = "Cancelar"
            });

            if (result.IsConfirmed)
            {
                var usuario = await ObtenerValorInput("swal-input-usuario");
                var password = await ObtenerValorInput("swal-input-password");

                await ValidarCredenciales(usuario, password);
            }
        }

        private async Task<string> ObtenerValorInput(string id)
        {
            return await JsRuntime.InvokeAsync<string>("document.getElementById(arguments[0]).value", id);
        }

        private async Task ValidarCredenciales(string usuario, string password)
        {
            // Validación básica de campos no vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                await SweetAlertService.FireAsync(new SweetAlertOptions
                {
                    Title = "Error",
                    Text = "Por favor, ingrese usuario y contraseña",
                    Icon = SweetAlertIcon.Error
                });
                return;
            }

            try
            {
                // Ejemplo simplificado de validación
                bool credencialesValidas = usuario == "admin" && password == "password";

                if (credencialesValidas)
                {
                    await SweetAlertService.FireAsync(new SweetAlertOptions
                    {
                        Title = "Inicio de Sesión Exitoso",
                        Text = $"Bienvenido, {usuario}",
                        Icon = SweetAlertIcon.Success
                    });
                    // Aquí podrías navegar a otra página o realizar acciones posteriores al login
                }
                else
                {
                    await SweetAlertService.FireAsync(new SweetAlertOptions
                    {
                        Title = "Error de Inicio de Sesión",
                        Text = "Usuario o contraseña incorrectos",
                        Icon = SweetAlertIcon.Error
                    });
                }
            }
            catch (Exception ex)
            {
                await SweetAlertService.FireAsync(new SweetAlertOptions
                {
                    Title = "Error",
                    Text = $"Ocurrió un error: {ex.Message}",
                    Icon = SweetAlertIcon.Error
                });
            }
        }
    }
}