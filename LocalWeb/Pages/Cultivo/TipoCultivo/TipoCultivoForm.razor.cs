using CurrieTechnologies.Razor.SweetAlert2;
using LocalShared.Entities.Cultivo;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components;

namespace LocalWeb.Pages.Cultivo.TipoCultivo
{
    public partial class TipoCultivoForm
    {
        private EditContext editContext = null!;

        [EditorRequired, Parameter] public ClsMTipoCultivo TipoCultivo{ get; set; } = null!;
        [EditorRequired, Parameter] public EventCallback OnValidSudmit { get; set; }
        [EditorRequired, Parameter] public EventCallback ReturnAction { get; set; }
        [Inject] public SweetAlertService SweetAlertService { get; set; } = null!;
        public bool FormPostedSuccessfully { get; set; }

        protected override void OnInitialized()
        {
            editContext = new(TipoCultivo);
        }

        private async Task OnBeforeInternalNavigation(LocationChangingContext context)
        {
            var formWasEdited = editContext.IsModified();
            if (!formWasEdited || FormPostedSuccessfully)
            {
                return;
            }

            var result = await SweetAlertService.FireAsync(new SweetAlertOptions
            {
                Title = "Confirmacions",
                Text = "¿Deseas abandonar la pagina y perder los cambios?",
                Icon = SweetAlertIcon.Question,
                ShowCancelButton = true,
            });
            var confirm = !string.IsNullOrEmpty(result.Value);
            if (confirm)
            {
                return;
            }
            context.PreventNavigation();
        }
    }
}
