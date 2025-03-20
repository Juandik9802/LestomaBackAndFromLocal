using LocalShared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Medicion
{
    public class ClsMTipoMedicion : IEntityWithName
    {
        [Key]
        public Guid IdTipoMedicion { get; set; }

        [Display(Name = "Tipo de Medicion")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string? Nombre { get; set; }

        public ICollection<ClsMUnidadMedida>? unidadMedidas { get; set; }

        [Display(Name = "Unidades de medida")]
        public int UnidadMedidaNumber => unidadMedidas == null || unidadMedidas.Count == 0 ? 0 : unidadMedidas.Count;
    }
}
