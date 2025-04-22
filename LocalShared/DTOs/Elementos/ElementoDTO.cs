using System.ComponentModel.DataAnnotations;

namespace LocalShared.DTOs.Elementos
{
    public class ElementoDTO
    {
        public Guid IdElemento { get; set; } = Guid.NewGuid();
        public string NombreElemento { get; set; }

        public string TipoElemento { get; set; } = "";
        public Guid IdTipoElemento { get; set; }
        public bool Estado { get; set; }
    }
}
