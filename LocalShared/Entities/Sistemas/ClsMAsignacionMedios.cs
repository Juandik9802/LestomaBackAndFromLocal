using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Sistemas
{
    public class ClsMAsignacionMedios
    {
        [Key]
        [Display(Name ="Identificador de la asignacion del medio")]
        public Guid IdAsignacionMedio { get; set; }
        [Display(Name ="Identificador del Medio de produccion")]
        public Guid IdMedio { get; set; }
        [Display(Name ="Identificador de tipo de elemento")]
        public Guid IdTipoElemento { get; set; }
    }
}
