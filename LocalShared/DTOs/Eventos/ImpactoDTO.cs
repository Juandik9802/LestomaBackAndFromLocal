using LocalShared.Entities.Medicion;
using LocalShared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.DTOs.Eventos
{
    public class ImpactoDTO:IEntityWithName
    {
        [Key]
        public Guid IdImpacto { get; set; } = Guid.NewGuid();

        [Display(Name = "Tipo de dispositivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }

        public ICollection<TipoEventoDTO>? tipoEventos { get; set; }

        [Display(Name = "Tipos de eventos")]
        public int TipoEventosNumber => tipoEventos == null || tipoEventos.Count == 0 ? 0 : tipoEventos.Count;

    }
}
