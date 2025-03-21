using LocalShared.Entities.Eventos;
using LocalShared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Sistemas
{
    public class ClsMSistema : IEntityWithName
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid IdSistema { get; set; }

        [Required]
        public string? Nombre { get; set; }

        public ICollection<ClsMAsignacionSistema>? AsignacionSistemas { get; set; } // Propiedad de navegación

        [Display(Name = "Asignacion de Sistemas")]
        public int AsignacionSistemasNumber => AsignacionSistemas == null || AsignacionSistemas.Count == 0 ? 0 : AsignacionSistemas.Count;
    }
}
