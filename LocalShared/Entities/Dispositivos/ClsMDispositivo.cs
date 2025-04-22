using LocalShared.Entities.Medicion;
using LocalShared.Entities.Sistemas;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
namespace LocalShared.Entities.Dispositivos;

[Table("Dispositivo")]
[Index("IdAsignacionSistema", Name = "IX_Dispositivo_AsignacionSistemaId")]
[Index("IdMarca", Name = "IX_Dispositivo_MarcaId")]
[Index("IdTipoDispositivo", Name = "IX_Dispositivo_TipoDispositivoId")]
public partial class ClsMDispositivo
{
    [Key]
    public Guid IdDispositivo { get; set; } = Guid.NewGuid();

    [StringLength(100)]
    [Display(Name = "Nombre del dispositivo")]
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
    public string Nombre { get; set; } = null!;

    public Guid? IdAsignacionSistema { get; set; }

    public Guid? IdTipoDispositivo { get; set; }

    public Guid IdMarca { get; set; }

    [Column("SN")]
    public string? Sn { get; set; }

    public string? Descripcion { get; set; }

    [ForeignKey("IdAsignacionSistema")]
    [InverseProperty("Dispositivos")]
    public virtual ClsMAsignacionSistema? IdAsignacionSistemaNavigation { get; set; }

    [ForeignKey("IdMarca")]
    [InverseProperty("Dispositivos")]
    public virtual ClsMMarca IdMarcaNavigation { get; set; } = null!;

    [ForeignKey("IdTipoDispositivo")]
    [InverseProperty("Dispositivos")]
    public virtual ClsMTipoDispositivo? IdTipoDispositivoNavigation { get; set; }

    [InverseProperty("IdDispositivoNavigation")]
    public virtual ICollection<ClsMLogsEstado> LogsEstados { get; set; } = new List<ClsMLogsEstado>();

    [InverseProperty("IdDispositivoNavigation")]
    public virtual ICollection<ClsMMedicion> Medicions { get; set; } = new List<ClsMMedicion>();

    [InverseProperty("IdDispositivoNavigation")]
    public virtual ICollection<ClsMPuntoOptimo> PuntoOptimos { get; set; } = new List<ClsMPuntoOptimo>();
    [Display(Name = "Unidades de medida")]
    public int LogsEstadosNumber => LogsEstados == null || LogsEstados.Count == 0 ? 0 : LogsEstados.Count;
}



