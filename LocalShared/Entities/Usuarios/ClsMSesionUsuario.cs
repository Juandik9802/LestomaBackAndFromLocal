using LocalShared.Entities.Auditoria;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LocalShared.Entities.Usuarios;

[Table("SesionUsuario")]
public partial class ClsMSesionUsuario
{
    [Key]
    public Guid IdSesion { get; set; } = Guid.NewGuid();

    public Guid IdUsuario { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string TokenSesion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? FechaInicio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaExpiracion { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("SesionUsuarios")]
    public virtual ClsMUsuario IdUsuarioNavigation { get; set; } = null!;
}
