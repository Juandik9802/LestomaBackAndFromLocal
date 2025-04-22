using LocalShared.Entities.Dispositivos;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LocalShared.Entities.Medicion;

[Table("Medicion")]
[Index("IdDispositivo", Name = "IX_Medicion_DispositivoId")]
[Index("IdUnidadMedida", Name = "IX_Medicion_UnidadMedidaId")]
public partial class ClsMMedicion
{
    [Key]
    public Guid IdMedicion { get; set; } = Guid.NewGuid();

    public Guid? IdDispositivo { get; set; }

    public Guid? IdUnidadMedida { get; set; }

    [Column("valor")]
    public float Valor { get; set; }

    public DateTime Fecha { get; set; }

    [ForeignKey("IdDispositivo")]
    [InverseProperty("Medicions")]
    public virtual ClsMDispositivo? IdDispositivoNavigation { get; set; }

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("Medicions")]
    public virtual ClsMUnidadMedida? IdUnidadMedidaNavigation { get; set; }
}

