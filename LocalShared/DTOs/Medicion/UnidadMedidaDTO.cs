using LocalShared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.DTOs.Medicion
{
    public class UnidadMedidaDTO:IEntityWithName
    {
        [Key]
        public Guid IdUnidadMedida { get; set; } = Guid.NewGuid();
        public Guid TipoMedicionId { get; set; }
        public TipoMedicionDTO? TipoMedicion { get; set; }

        public string? Nombre { get; set; }
        public string? Simbolo { get; set; }

        public ICollection<MedicionDTO>? MMediciones { get; set; } // Propiedad de navegación

        [Display(Name = "Mediciones")]
        public int MedicionesNumber => MMediciones == null || MMediciones.Count == 0 ? 0 : MMediciones.Count;
    }
}