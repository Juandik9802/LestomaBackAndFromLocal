using LocalShared.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LocalShared.Entities.Dispositivos;


[Table("EstadosDispositivo")]
[Index("Nombre", Name = "IX_EstadosDispositivo_Nombre", IsUnique = true)]
public partial class ClsMEstadosDispositivo
{
    [Key]
    public Guid IdEstadoDispositivo { get; set; } = Guid.NewGuid();

    public Guid IdTipoDispositivo { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [ForeignKey("IdTipoDispositivo")]
    [InverseProperty("EstadosDispositivos")]
    public virtual ClsMTipoDispositivo IdTipoDispositivoNavigation { get; set; } = null!;

    [InverseProperty("IdEstadoDispositivoNavigation")]
    public virtual ICollection<ClsMLogsEstado> LogsEstados { get; set; } = new List<ClsMLogsEstado>();
}
