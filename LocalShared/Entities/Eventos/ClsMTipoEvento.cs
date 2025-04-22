using LocalShared.Entities.Medicion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalShared.Entities.Eventos;



[Table("TipoEvento")]
public partial class ClsMTipoEvento
{
    [Key]
    [Display(Name = "Identificador unico del Tipo de evento")]
    public Guid IdTipoEvento { get; set; } = Guid.NewGuid();

    [StringLength(50)]
    [Display(Name = "Tipo de dispositivo")]
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
    public string Nombre { get; set; } = null!;

    public Guid IdImpacto { get; set; }

    [InverseProperty("IdTipoEventoNavigation")]
    public virtual ICollection<ClsMEvento> Eventos { get; set; } = new List<ClsMEvento>();

    [ForeignKey("IdImpacto")]
    [InverseProperty("TipoEventos")]
    public virtual ClsMImpacto IdImpactoNavigation { get; set; } = null!;


}


