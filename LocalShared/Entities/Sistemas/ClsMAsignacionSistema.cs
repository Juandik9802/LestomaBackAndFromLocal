using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Sistemas
{
    public class ClsMAsignacionSistema
    {
        [Key]
        [Display (Name ="Identificador de asignacion")]
        public Guid IdAsignacionSistema { get; set; }
        
        //pendiente relacion
        public Guid? IdUpa { get; set; }
        public Guid? SistemaId { get; set; }
        public ClsMSistema? Sistema { get; set; }

        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
        public ICollection<ClsMPropiedadesSistema> propiedadesSistemas { get; set; }
    }
}
