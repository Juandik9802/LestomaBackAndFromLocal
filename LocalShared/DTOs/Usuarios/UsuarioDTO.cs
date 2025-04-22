using LocalShared.Entities.Auditoria;
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
    public class UsuarioDTO
    {
        public Guid IdUsuario { get; set; } = Guid.NewGuid();
        public string Nombre { get; set; } 
        public string Apellido { get; set; } = null!;

        public string Email { get; set; } = null!;

        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<ClsMAuditoria> Auditoria { get; set; } = new List<ClsMAuditoria>();

        public virtual ICollection<ClsMSesionUsuario> SesionUsuarios { get; set; } = new List<ClsMSesionUsuario>();
    }
}
