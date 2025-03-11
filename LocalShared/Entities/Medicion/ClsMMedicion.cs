using LocalShared.Entities.Dispositivos;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Medicion
{
    public class ClsMMedicion
    {
        [Key]
        public Guid IdMedicion { get; set; }

        // Cambia DispositivosId a DispositivoId
        public Guid DispositivoId { get; set; }
        public ClsMDispositivo? Dispositivo { get; set; }

        // Cambia UnidadMedidaId a UnidadMedidaId (ya está correcto)
        public Guid UnidadMedidaId { get; set; }
        public ClsMUnidadMedida? UnidadMedida { get; set; }

        public float valor { get; set; }
        public DateTime Fecha { get; set; }
    }
}
