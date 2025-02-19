using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Eventos
{
    public class ClsMTipoEvento
    {
        [Key]
        [Display(Name = "Identificador unico del Tipo de evento")]
        public Guid IdTipoEvento { get; set; }

        [Display(Name = "Tipo de dispositivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }

        public Guid IdImpacto { get; set; }

    }
}
