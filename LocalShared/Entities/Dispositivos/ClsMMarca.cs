using LocalShared.Entities.Medicion;
using LocalShared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Dispositivos
{
    public class ClsMMarca : IEntityWithName
    {
        [Key]
        public Guid IdMarca { get; set; }

        [Display(Name = "Nombre de la marca")]
        [Required]
        public string? Nombre { get; set; }

        public ICollection<ClsMDispositivo>? mDispositivos { get; set; } // Propiedad de navegación

        [Display(Name = "Dispositivos")]
        public int DispositivosNumber => mDispositivos == null || mDispositivos.Count == 0 ? 0 : mDispositivos.Count;
    }
}
