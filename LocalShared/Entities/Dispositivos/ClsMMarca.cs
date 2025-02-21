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
    }
}
