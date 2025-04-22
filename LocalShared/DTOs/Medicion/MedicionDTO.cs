using LocalShared.Entities.Dispositivos;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.DTOs.Medicion
{
    public class MedicionDTO
    {
        [Key]
        public Guid IdMedicion { get; set; } = Guid.NewGuid();
        public Guid? DispositivoId { get; set; }
        public ClsMDispositivo? Dispositivo { get; set; }
        public Guid? UnidadMedidaId { get; set; }
        public UnidadMedidaDTO? UnidadMedida { get; set; }
        public float valor { get; set; }
        public DateTime Fecha { get; set; }        

    }
}
