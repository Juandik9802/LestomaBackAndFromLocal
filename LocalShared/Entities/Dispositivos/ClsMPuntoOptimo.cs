using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Dispositivos
{
    public class ClsMPuntoOptimo
    {
        [Key]
        public Guid IdPuntoOPtimo { get; set; }

        [Display(Name = "Identificador del Dispositivo")]
        public Guid? DispositivoId { get; set; }
        public ClsMDispositivo? Dispositivo { get; set; }
        public float ValorOptimo { get; set; }
        public float ValorMaximo { get; set; }
        public float ValorMinimo { get; set; }
    }
}
