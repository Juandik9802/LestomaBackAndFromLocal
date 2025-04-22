using LocalShared.Entities.Usuarios;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LocalShared.Entities.Auditoria;
[Index("Fecha", Name = "IX_Auditoria_Fecha", IsUnique = true)]
public partial class ClsMAuditoria
{
    [Key]
    public Guid IdAuditoria { get; set; } = Guid.NewGuid();

    public Guid IdUsuario { get; set; }

    public string Accion { get; set; } = null!;

    public string Tabla { get; set; } = null!;

    public DateTime Fecha { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("Auditoria")]
    public virtual ClsMUsuario IdUsuarioNavigation { get; set; } = null!;
}