using LocalShared.Entities.Dispositivos;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Medicion
{
    public class ClsMMedicion
    {
        [Key]
        public Guid IdMedicion { get; set; }
        public Guid? DispositivoId { get; set; }
        public ClsMDispositivo? Dispositivo { get; set; }
        public Guid? UnidadMedidaId { get; set; }
        public ClsMUnidadMedida? UnidadMedida { get; set; }
        public float valor { get; set; }
        public DateTime Fecha { get; set; }        

    }
}
