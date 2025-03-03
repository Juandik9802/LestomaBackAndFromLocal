using LocalShared.Entities.Dispositivos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Medicion
{
    public class ClsMMedicion
    {
        [Key]
        public Guid IdMedicion { get; set; }
        public Guid DispositivosId { get; set; }
        public ClsMDispositivos? Dispositivos { get; set; }
        public Guid UnidadMedidaId { get; set; }
        public ClsMUnidadMedida? UnidadMedida { get; set; }

        public float valor { get; set; }
        public DateTime Fecha { get; set; }
    }
}
