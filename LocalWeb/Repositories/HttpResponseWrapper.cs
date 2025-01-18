using System.Net;

namespace LocalWeb.Repositories
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(T? responce, bool error, HttpResponseMessage httpResponseMessage)
        {
            Responce = responce;
            Error = error;
            HttpResponseMessage = httpResponseMessage;
        }

        public T? Responce { get; }
        public bool Error { get; }
        public HttpResponseMessage HttpResponseMessage { get; }

        public async Task<string?> GetErrorMessageAsync()
        {
            if (!Error)
            {
                return null;
            }

            var statusCode = HttpResponseMessage.StatusCode;
            if (statusCode == HttpStatusCode.NotFound)
            {
                return "Recurso no encontrado";
            }

            if (statusCode == HttpStatusCode.BadRequest)
            {
                return await HttpResponseMessage.Content.ReadAsStringAsync();
            }

            if (statusCode == HttpStatusCode.Unauthorized)
            {
                return "Tienes que iniciar secion para realizar esta accion";
            }

            if (statusCode == HttpStatusCode.Forbidden)
            {
                return "No Tiene permisos para realizar esta operación";
            }
            return "Ha ocurrido un error inesperado";
        }
    }
}
