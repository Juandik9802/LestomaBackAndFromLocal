using LocalShared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.DTOs.Sistemas
{
    public class MedioDTO:IEntityWithName
    {
        [Key]
        public Guid IdMedio { get; set; } = Guid.NewGuid();

        [Required]
        public string?  Nombre { get; set; }
    }
}
