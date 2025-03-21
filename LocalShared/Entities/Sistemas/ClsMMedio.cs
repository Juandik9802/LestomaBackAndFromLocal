using LocalShared.Entities.Eventos;
using LocalShared.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Sistemas
{
    public class ClsMMedio:IEntityWithName
    {
        [Key]
        public Guid IdMedio { get; set; }
        
        [Required]
        public string?  Nombre { get; set; }

        public ICollection<ClsMAsignacionMedio>? AsignacionMedios { get; set; } // Propiedad de navegación

        [Display(Name = "Asignacion de Medios de produccion")]
        public int AsignacionMediosNumber => AsignacionMedios == null || AsignacionMedios.Count == 0 ? 0 : AsignacionMedios.Count;
    }
}
