using LocalShared.Entities.Medicion;
using LocalShared.Entities.Sistemas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalShared.Entities.Elementos;

[Table("CantidadElemento")]
public partial class ClsMCantidadElemento
{
    [Key]
    public Guid IdCantidadElemento { get; set; } = Guid.NewGuid();

    public Guid IdElemento { get; set; }

    public Guid IdAsignacionSistema { get; set; }

    public float Cantidad { get; set; }

    public Guid IdUnidadMedida { get; set; }

    [ForeignKey("IdAsignacionSistema")]
    [InverseProperty("CantidadElementos")]
    public virtual ClsMAsignacionSistema IdAsignacionSistemaNavigation { get; set; } = null!;

    [ForeignKey("IdElemento")]
    [InverseProperty("CantidadElementos")]
    public virtual ClsMElemento IdElementoNavigation { get; set; } = null!;

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("CantidadElementos")]
    public virtual ClsMUnidadMedida IdUnidadMedidaNavigation { get; set; } = null!;
}

