using LocalShared.Entities.Medicion;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.DTOs.Eventos
{
    public class TipoEventoDTO
    {
        [Key]
        [Display(Name = "Identificador unico del Tipo de evento")]
        public Guid IdTipoEvento { get; set; } = Guid.NewGuid();

        [Display(Name = "Tipo de dispositivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }

        public Guid ImpactoId { get; set; }
        public ImpactoDTO? Impacto { get; set; }

        public ICollection<EventoDTO>? eventos { get; set; } // Propiedad de navegación

        [Display(Name = "Mediciones")]
        public int eventosNumber => eventos == null || eventos.Count == 0 ? 0 : eventos.Count;
    }
}
