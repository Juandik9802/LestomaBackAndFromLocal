using LocalShared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Medicion
{
    public class ClsMUnidadMedida:IEntityWithName
    {
        [Key]
        public Guid IdUnidadMedida { get; set; }
        public Guid TipoMedicionId { get; set; }
        public ClsMTipoMedicion? TipoMedicion { get; set; }

        public string? Nombre { get; set; }
        public string? Simbolo { get; set; }

        public ICollection<ClsMMedicion>? MMediciones { get; set; } // Propiedad de navegación

        [Display(Name = "Mediciones")]
        public int MedicionesNumber => MMediciones == null || MMediciones.Count == 0 ? 0 : MMediciones.Count;
    }
}