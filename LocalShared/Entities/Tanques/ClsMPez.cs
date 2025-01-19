using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Tanques
{
    public class ClsMPez
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid? PezId { get; set; }

        [Display(Name = "Nombre de la especie")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? PezNombre { get; set; }

        [Display(Name = "Identificador unico del estado del pez")]
        public Guid? PezStdId { get; set; }

    }
}
