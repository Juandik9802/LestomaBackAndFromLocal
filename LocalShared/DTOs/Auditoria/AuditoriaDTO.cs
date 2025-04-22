using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.DTOs.Auditoria
{
    public class AuditoriaDTO
    {
        [Key]
        [Display(Name = "Identificador")]
        public Guid IdAuditoria { get; set; } = Guid.NewGuid();

        [Display(Name = "Identificador del usuario")]
        [Required]
        public Guid IdUsuario { get; set; }

        [Display(Name = "Accion realizada")]
        [Required]
        public string? Accion { get; set; }

        [Display(Name = "Tabla involucrada")]
        [Required]
        public string? Tabla { get; set; }

        [Display(Name = "Fecha en la que se produce la accion")]
        [Required]
        public DateTime Fecha { get; set; }

    }
}
