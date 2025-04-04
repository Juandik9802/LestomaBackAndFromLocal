using LocalShared.Entities.Medicion;
using LocalShared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Eventos
{
    public class ClsMTipoEvento:IEntityWithName
    {
        [Key]
        [Display(Name = "Identificador unico del Tipo de evento")]
        public Guid IdTipoEvento { get; set; }

        [Display(Name = "Tipo de dispositivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }

        public Guid ImpactoId { get; set; }
        public ClsMImpacto? Impacto { get; set; }

        public ICollection<ClsMEvento>? eventos { get; set; } // Propiedad de navegación

        [Display(Name = "Mediciones")]
        public int eventosNumber => eventos == null || eventos.Count == 0 ? 0 : eventos.Count;
    }
}
