using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.DTOs.Dispositivos
{
    public class PuntoOptimoDTO
    {
        [Key]
        public Guid IdPuntoOPtimo { get; set; } = Guid.NewGuid();

        [Display(Name = "Identificador del Dispositivo")]
        public Guid IdDispositivo { get; set; }

        public float ValorOptimo { get; set; }
        public float ValorMaximo { get; set; }
        public float ValorMinimo { get; set; }
    }
}
