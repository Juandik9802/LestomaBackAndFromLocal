using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Dispositivos;

[Table("PuntoOptimo")]
public partial class ClsMPuntoOptimo
{
    [Key]
    [Column("IdPuntoOPtimo")]
    public Guid IdPuntoOptimo { get; set; } = Guid.NewGuid();

    public Guid IdDispositivo { get; set; }

    public float ValorOptimo { get; set; }

    public float ValorMaximo { get; set; }

    public float ValorMinimo { get; set; }

    [ForeignKey("IdDispositivo")]
    [InverseProperty("PuntoOptimos")]
    public virtual ClsMDispositivo IdDispositivoNavigation { get; set; } = null!;
}
