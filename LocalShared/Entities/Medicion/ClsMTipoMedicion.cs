using LocalShared.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LocalShared.Entities.Medicion;

[Table("TipoMedicion")]
[Index("Nombre", Name = "IX_TipoMedicion_Nombre", IsUnique = true)]
public partial class ClsMTipoMedicion
{
    [Key]
    public Guid IdTipoMedicion { get; set; } = Guid.NewGuid();

    [Display(Name = "Tipo de Medicion")]
    [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
    [Required(ErrorMessage = "El campo {0} es requerido.")]
    public string Nombre { get; set; } = null!;

    [InverseProperty("IdTipoMedicionNavigation")]
    public virtual ICollection<ClsMUnidadMedida> UnidadMedida { get; set; } = new List<ClsMUnidadMedida>();
}

