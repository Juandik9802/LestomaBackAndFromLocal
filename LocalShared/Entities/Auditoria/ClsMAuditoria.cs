using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Auditoria
{
    public class ClsMAuditoria
    {
        [Key]
        [Display(Name = "Identificador")]
        public Guid IdAuditoria { get; set; }

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
