using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Dispositivos
{
    public class ClsMLogsEstado
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid IdLogsEstados { get; set; }
        public Guid? DispositivoId { get; set; }
        public ClsMDispositivo? Dispositivo { get; set; }
        public Guid EstadoDipositivoId { get; set; }
        public ClsMEstadosDispositivo? EstadoDipositivo { get; set; }

        [Display(Name = "Fecha y hora de la modificacion de estados")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }
    }
}
