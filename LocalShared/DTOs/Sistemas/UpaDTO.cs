using LocalShared.Entities.Sistemas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.DTOs.Sistemas
{
    public class UpaDTO
    {
        public Guid IdUpa { get; set; } = Guid.NewGuid();
        public string? Nombre { get; set; }

        public string? Ubicacion { get; set; }

        public virtual ICollection<ClsMAsignacionSistema> AsignacionSistemas { get; set; } = new List<ClsMAsignacionSistema>();
    }
}
