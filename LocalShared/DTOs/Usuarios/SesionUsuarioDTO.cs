using LocalShared.Entities.Usuarios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.DTOs.Usuarios
{
    public class SesionUsuarioDTO
    {

        public Guid IdSesion { get; set; } = Guid.NewGuid();

        public Guid IdUsuario { get; set; }

        public string TokenSesion { get; set; } = null!;

        public DateTime? FechaInicio { get; set; }

        public DateTime FechaExpiracion { get; set; }

        public virtual ClsMUsuario IdUsuarioNavigation { get; set; } = null!;
    }
}
