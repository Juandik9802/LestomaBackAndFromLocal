using LocalShared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Dispositivos
{
    public class ClsMEstadosDispositivos
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid IdEstadoDispositivo { get; set; }
        public Guid IdTipoDispositivo { get; set; }

        [Display(Name = "")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }
    }
}
