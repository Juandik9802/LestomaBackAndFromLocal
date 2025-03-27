using LocalShared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Dispositivos
{
    public class ClsMEstadosDispositivo:IEntityWithName
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid IdEstadoDispositivo { get; set; }

        [Display(Name = "Estado del dipositivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }

        public ICollection<ClsMLogsEstado>? LogsEstados { get; set; }

        [Display(Name = "Registro de estados")]
        public int LogsEstadosNumber => LogsEstados == null || LogsEstados.Count == 0 ? 0 : LogsEstados.Count;
    }
}
