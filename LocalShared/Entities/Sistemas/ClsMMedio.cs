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

namespace LocalShared.Entities.Sistemas;

[Table("Medio")]
[Index("Nombre", Name = "IX_Medio_Nombre", IsUnique = true)]
public partial class ClsMMedio
{
    [Key]
    public Guid IdMedio { get; set; } = Guid.NewGuid();

    public string Nombre { get; set; } = null!;

    [InverseProperty("IdMedioNavigation")]
    public virtual ICollection<ClsMAsignacionMedio> AsignacionMedios { get; set; } = new List<ClsMAsignacionMedio>();
}

