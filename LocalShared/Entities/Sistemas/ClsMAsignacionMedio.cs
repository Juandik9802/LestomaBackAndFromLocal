using LocalShared.Entities.Elementos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Sistemas
{
    public class ClsMAsignacionMedio
    {
        [Key]
        [Display(Name ="Identificador de la asignacion del medio")]
        public Guid? IdAsignacionMedio { get; set; }
        [Display(Name ="Identificador del Medio de produccion")]
        public Guid? MedioId { get; set; }
        public ClsMMedio? Medio { get; set; }

        [Display(Name ="Identificador de tipo de elemento")]
        public Guid? TipoElementoId { get; set; }
        public ClsMTipoElemento TipoElemento { get; set; }
    }
}
