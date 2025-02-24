using LocalShared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Sistemas
{
    public class ClsMMedio:IEntityWithName
    {
        [Key]
        public Guid IdMedio { get; set; }
        
        [Required]
        public string?  Nombre { get; set; }
    }
}
