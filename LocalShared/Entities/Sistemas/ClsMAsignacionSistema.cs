using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Sistemas;

[Table("AsignacionSistema")]
public partial class ClsMAsignacionSistema
{
    [Key]
    public Guid IdAsignacionSistema { get; set; } = Guid.NewGuid();

    public Guid IdUpa { get; set; }

    public Guid IdSistema { get; set; }

    public DateTime Fecha { get; set; }

    public bool Estado { get; set; }

    [InverseProperty("IdAsignacionSistemaNavigation")]
    public virtual ICollection<ClsMCantidadElemento> CantidadElementos { get; set; } = new List<ClsMCantidadElemento>();

    [InverseProperty("IdAsignacionSistemaNavigation")]
    public virtual ICollection<ClsMDispositivo> Dispositivos { get; set; } = new List<ClsMDispositivo>();

    [InverseProperty("IdAsignacionSistemaNavigation")]
    public virtual ICollection<ClsMEvento> Eventos { get; set; } = new List<ClsMEvento>();

    [ForeignKey("IdSistema")]
    [InverseProperty("AsignacionSistemas")]
    public virtual ClsMSistema IdSistemaNavigation { get; set; } = null!;

    [ForeignKey("IdUpa")]
    [InverseProperty("AsignacionSistemas")]
    public virtual ClsMUpa IdUpaNavigation { get; set; } = null!;

    [InverseProperty("IdAsignacionSistemaNavigation")]
    public virtual ICollection<ClsMPropiedadSistema> PropiedadSistemas { get; set; } = new List<ClsMPropiedadSistema>();
}
