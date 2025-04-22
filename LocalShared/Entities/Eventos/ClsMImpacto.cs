using LocalShared.Entities.Medicion;
using LocalShared.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LocalShared.Entities.Eventos;

[Table("Impacto")]
[Index("Nombre", Name = "IX_Impacto_Nombre", IsUnique = true)]
public partial class ClsMImpacto
{
    [Key]
    public Guid IdImpacto { get; set; } = Guid.NewGuid();

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("IdImpactoNavigation")]
    public virtual ICollection<ClsMTipoEvento> TipoEventos { get; set; } = new List<ClsMTipoEvento>();
    public int TipoEventosNumber => TipoEventos == null || TipoEventos.Count == 0 ? 0 : TipoEventos.Count;
}


