using LocalShared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Medicion
{
    public class ClsMTipoMedicion:IEntityWithName
    {
        [Key]
        public Guid IdTipoMedicion { get; set; }
        public string? Nombre { get; set; }
    }
}
