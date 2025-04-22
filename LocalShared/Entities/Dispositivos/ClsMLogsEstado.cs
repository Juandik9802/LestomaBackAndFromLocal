using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalShared.Entities.Dispositivos;

[Table("LogsEstado")]
public partial class ClsMLogsEstado
{
    [Key]
    public Guid IdLogsEstados { get; set; } = Guid.NewGuid();

    public Guid IdDispositivo { get; set; }

    public Guid IdEstadoDispositivo { get; set; }

    public DateTime Fecha { get; set; }

    [ForeignKey("IdDispositivo")]
    [InverseProperty("LogsEstados")]
    public virtual ClsMDispositivo IdDispositivoNavigation { get; set; } = null!;

    [ForeignKey("IdEstadoDispositivo")]
    [InverseProperty("LogsEstados")]
    public virtual ClsMEstadosDispositivo IdEstadoDispositivoNavigation { get; set; } = null!;
}
