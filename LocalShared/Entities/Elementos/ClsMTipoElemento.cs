using LocalShared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Elementos
{
    public class ClsMTipoElemento:IEntityWithName
    {
        [Key]
        public Guid IdTipoElemento { get; set; }

        [Display(Name = "Tipo de dispositivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }

        public ICollection<ClsMElemento> Elementos { get; set; }

        public int ElementosNumber => Elementos == null || Elementos.Count == 0 ? 0 : Elementos.Count;

    }
}
