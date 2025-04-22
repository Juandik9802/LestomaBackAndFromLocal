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

namespace LocalShared.Entities.Dispositivos;

[Table("TipoDispositivo")]
[Index("Nombre", Name = "IX_TipoDispositivo_Nombre", IsUnique = true)]
public partial class ClsMTipoDispositivo
{
    [Key]
    public Guid IdTipoDispositivo { get; set; } = Guid.NewGuid();

    [StringLength(100)]
    [Display(Name = "Tipo de dispositivo")]
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
    public string Nombre { get; set; } = null!;

    [InverseProperty("IdTipoDispositivoNavigation")]
    public virtual ICollection<ClsMDispositivo> Dispositivos { get; set; } = new List<ClsMDispositivo>();

    [InverseProperty("IdTipoDispositivoNavigation")]
    public virtual ICollection<ClsMEstadosDispositivo> EstadosDispositivos { get; set; } = new List<ClsMEstadosDispositivo>();
}



