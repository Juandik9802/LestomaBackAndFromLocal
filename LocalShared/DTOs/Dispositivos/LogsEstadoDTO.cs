using System.ComponentModel.DataAnnotations;

namespace LocalShared.DTOs.Dispositivos
{
    public class LogsEstadoDTO
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid IdLogsEstados { get; set; } = Guid.NewGuid();
        public Guid IdDispositivo { get; set; }
        public Guid IdEstadoDsipositivo { get; set; }

        [Display(Name = "Fecha y hora de la modificacion de estados")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime MyProperty { get; set; }
    }
}
