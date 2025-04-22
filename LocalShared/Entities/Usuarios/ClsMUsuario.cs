using LocalShared.Entities.Auditoria;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LocalShared.Entities.Usuarios;


[Table("Usuario")]
[Index("Email", Name = "UQ__Usuario__A9D105346F714A65", IsUnique = true)]
public partial class ClsMUsuario
{
    [Key]
    public Guid IdUsuario { get; set; } = Guid.NewGuid();

    [StringLength(100)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Apellido { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? FechaRegistro { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<ClsMAuditoria> Auditoria { get; set; } = new List<ClsMAuditoria>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<ClsMSesionUsuario> SesionUsuarios { get; set; } = new List<ClsMSesionUsuario>();
}

