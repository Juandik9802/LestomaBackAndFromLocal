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
        public Guid IdUpa { get; set; }
        public Guid IdSistema { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }    
    }
}
