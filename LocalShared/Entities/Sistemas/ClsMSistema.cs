using LocalShared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Sistemas
{
    public class ClsMSistema:IEntityWithName
    {
        [Key]
        [Display(Name ="Identificador unico")]
        public Guid IdSistema { get; set; }
        public string? Nombre { get; set; }
    }
}
