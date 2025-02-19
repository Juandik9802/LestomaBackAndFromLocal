using LocalShared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Dispositivos
{
    public class ClsMMarca:IEntityWithName
    {
        [Key]
        public Guid IdMarca { get; set; }

        [Display(Name ="Nombre de la marca")]
        [Required]
        public string? Nombre { get; set; }       
    }
}
