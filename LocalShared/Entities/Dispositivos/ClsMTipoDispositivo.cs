using LocalShared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Dispositivos
{
    public class ClsMTipoDispositivo:IEntityWithName
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid IdTipoDispositivo { get; set; }

        [Display(Name = "Tipo de dispositivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }      

        public ICollection<ClsMDispositivo> mDispositivos { get; set; }
        [Display(Name ="Dispositivos")]
        public int DispositivosNumber => mDispositivos == null || mDispositivos.Count == 0 ? 0 : mDispositivos.Count;
    }
}
