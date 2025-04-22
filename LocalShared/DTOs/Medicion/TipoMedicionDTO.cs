using LocalShared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.DTOs.Medicion
{
    public class TipoMedicionDTO : IEntityWithName
    {
        [Key]
        public Guid IdTipoMedicion { get; set; } = Guid.NewGuid();

        [Display(Name = "Tipo de Medicion")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string? Nombre { get; set; }

        public ICollection<UnidadMedidaDTO>? unidadMedidas { get; set; }

        [Display(Name = "Unidades de medida")]
        public int UnidadMedidaNumber => unidadMedidas == null || unidadMedidas.Count == 0 ? 0 : unidadMedidas.Count;
    }
}
