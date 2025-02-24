using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Medicion
{
    public class ClsMUnidadMedida
    {
        [Key]
        public Guid IdUnidadMedida { get; set; }

        public Guid TipoMedicion { get; set; }

        [Required]
        public string? Nombre { get; set; }

        public string? Simbolo { get; set; }
    }
}
