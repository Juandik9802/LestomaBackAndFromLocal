using LocalShared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Sistemas
{
    public class ClsMMedioProduccion:IEntityWithName
    {
        [Key]
        public Guid IdMedioProduccion { get; set; }
        
        [Required]
        public string?  Nombre { get; set; }
    }
}
