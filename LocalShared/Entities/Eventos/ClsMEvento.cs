using LocalShared.Entities.Elementos;
using LocalShared.Entities.Medicion;
using LocalShared.Entities.Sistemas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Eventos;

[Table("Evento")]
public partial class ClsMEvento
{
    [Key]
    public Guid IdEvento { get; set; } = Guid.NewGuid();

    public Guid IdAsignacionSistema { get; set; }

    public Guid IdElemento { get; set; }

    public Guid IdAtributoSistema { get; set; }

    public Guid? IdTipoEvento { get; set; }

    public float Cantidad { get; set; }

    public Guid IdUnidadMedida { get; set; }

    [Display(Name = "Fecha y hora del evento")]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime FechaEvento { get; set; }

    [ForeignKey("IdAsignacionSistema")]
    [InverseProperty("Eventos")]
    public virtual ClsMAsignacionSistema IdAsignacionSistemaNavigation { get; set; } = null!;

    [ForeignKey("IdAtributoSistema")]
    [InverseProperty("Eventos")]
    public virtual ClsMPropiedadSistema IdAtributoSistemaNavigation { get; set; } = null!;

    [ForeignKey("IdElemento")]
    [InverseProperty("Eventos")]
    public virtual ClsMElemento IdElementoNavigation { get; set; } = null!;

    [ForeignKey("IdTipoEvento")]
    [InverseProperty("Eventos")]
    public virtual ClsMTipoEvento? IdTipoEventoNavigation { get; set; }

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("Eventos")]
    public virtual ClsMUnidadMedida IdUnidadMedidaNavigation { get; set; } = null!;
}