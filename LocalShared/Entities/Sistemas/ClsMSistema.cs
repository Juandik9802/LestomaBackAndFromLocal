using LocalShared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Sistemas;

[Table("Sistema")]
public partial class ClsMSistema
{
    [Key]
    public Guid IdSistema { get; set; } = Guid.NewGuid();

    public string? Nombre { get; set; }

    [InverseProperty("IdSistemaNavigation")]
    public virtual ICollection<ClsMAsignacionSistema> AsignacionSistemas { get; set; } = new List<ClsMAsignacionSistema>();
}

