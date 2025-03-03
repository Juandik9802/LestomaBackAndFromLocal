using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Elementos
{
    public class ClsMElementos
    {
        [Key]
        [Display(Name ="Identificador del elemento")]
        public Guid IdElemento { get; set; }        

        public Guid IdTipoElemento { get; set; }
        public ClsMTipoElementos TipoElementos { get; set; }

        [Display(Name = "Nombre del elemento")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }
        public bool Estado { get; set; }
    }
}
