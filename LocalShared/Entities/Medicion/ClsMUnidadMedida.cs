using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;
using LocalShared.Entities.Sistemas;
using LocalShared.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LocalShared.Entities.Medicion;
[Index("IdTipoMedicion", Name = "IX_UnidadMedida_TipoMedicionId")]
public partial class ClsMUnidadMedida
{
    [Key]
    public Guid IdUnidadMedida { get; set; } = Guid.NewGuid();

    public Guid IdTipoMedicion { get; set; }

    public string? Nombre { get; set; }

    public string? Simbolo { get; set; }

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<ClsMCantidadElemento> CantidadElementos { get; set; } = new List<ClsMCantidadElemento>();

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<ClsMEvento> Eventos { get; set; } = new List<ClsMEvento>();

    [ForeignKey("IdTipoMedicion")]
    [InverseProperty("UnidadMedida")]
    public virtual ClsMTipoMedicion IdTipoMedicionNavigation { get; set; } = null!;
    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<ClsMMedicion> Medicions { get; set; } = new List<ClsMMedicion>();

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<ClsMPropiedadSistema> PropiedadSistemas { get; set; } = new List<ClsMPropiedadSistema>();
}
