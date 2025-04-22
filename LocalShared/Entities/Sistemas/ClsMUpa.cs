using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Sistemas;

[Table("Upa")]
public partial class ClsMUpa
{
    [Key]
    public Guid IdUpa { get; set; } = Guid.NewGuid();

    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Ubicacion { get; set; }

    [InverseProperty("IdUpaNavigation")]
    public virtual ICollection<ClsMAsignacionSistema> AsignacionSistemas { get; set; } = new List<ClsMAsignacionSistema>();
}
