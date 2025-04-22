using LocalShared.Entities.Eventos;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LocalShared.Entities.Elementos;


[Table("Elemento")]
[Index("IdTipoElemento", Name = "IX_Elemento_IdTipoElemento")]
[Index("Nombre", Name = "IX_Elemento_Nombre", IsUnique = true)]
public partial class ClsMElemento
{
    [Key]
    public Guid IdElemento { get; set; } = Guid.NewGuid();

    public Guid IdTipoElemento { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    public bool Estado { get; set; }

    [InverseProperty("IdElementoNavigation")]
    public virtual ICollection<ClsMCantidadElemento> CantidadElementos { get; set; } = new List<ClsMCantidadElemento>();

    [InverseProperty("IdElementoNavigation")]
    public virtual ICollection<ClsMEvento> Eventos { get; set; } = new List<ClsMEvento>();

    [ForeignKey("IdTipoElemento")]
    [InverseProperty("Elementos")]
    public virtual ClsMTipoElemento IdTipoElementoNavigation { get; set; } = null!;
}

