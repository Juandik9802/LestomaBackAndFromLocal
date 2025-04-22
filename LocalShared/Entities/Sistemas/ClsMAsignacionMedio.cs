using LocalShared.Entities.Elementos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Sistemas;

[Table("AsignacionMedio")]
public partial class ClsMAsignacionMedio
{
    [Key]
    public Guid IdAsignacionMedio { get; set; } = Guid.NewGuid();

    public Guid IdMedio { get; set; }

    public Guid IdTipoElemento { get; set; }

    [ForeignKey("IdMedio")]
    [InverseProperty("AsignacionMedios")]
    public virtual ClsMMedio IdMedioNavigation { get; set; } = null!;

    [ForeignKey("IdTipoElemento")]
    [InverseProperty("AsignacionMedios")]
    public virtual ClsMTipoElemento IdTipoElementoNavigation { get; set; } = null!;

    [InverseProperty("IdAsignacionMedioNavigation")]
    public virtual ICollection<ClsMPropiedadSistema> PropiedadSistemas { get; set; } = new List<ClsMPropiedadSistema>();
}