using LocalShared.Entities.Medicion;
using LocalShared.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LocalShared.Entities.Dispositivos;

[Table("Marca")]
[Index("Nombre", Name = "IX_Marca_Nombre", IsUnique = true)]
public partial class ClsMMarca
{
    [Key]
    public Guid IdMarca { get; set; } = Guid.NewGuid();

    public string Nombre { get; set; } = null!;

    [InverseProperty("IdMarcaNavigation")]
    public virtual ICollection<ClsMDispositivo> Dispositivos { get; set; } = new List<ClsMDispositivo>();
    [Display(Name = "Dispositivos")]
    public int DispositivosNumber => Dispositivos == null || Dispositivos.Count == 0 ? 0 : Dispositivos.Count;
}

