using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Medicion;
using LocalShared.Entities.Sistemas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalShared.DTOs.Dispositivos
{
    public class DispositivoDTO
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid IdDispositivo { get; set; } = Guid.NewGuid();

        [Display(Name = "Nombre del dispositivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }

        public Guid? IdAsignacionSistema { get; set; }

        public Guid? IdTipoDispositivo { get; set; }

        public Guid IdMarca { get; set; }
        public string? SN { get; set; }
        public string? Descripcion { get; set; }

        public virtual ClsMAsignacionSistema? IdAsignacionSistemaNavigation { get; set; }
        public virtual ClsMMarca? IdMarcaNavigation { get; set; } = null!;
        public virtual ClsMTipoDispositivo? IdTipoDispositivoNavigation { get; set; }


        public ICollection<LogsEstadoDTO>? LogsEstados { get; set; }
        public virtual ICollection<ClsMMedicion> Medicions { get; set; } = new List<ClsMMedicion>();
        public virtual ICollection<ClsMPuntoOptimo> PuntoOptimos { get; set; } = new List<ClsMPuntoOptimo>();
        public MarcaDTO? Marca { get; set; }

        [Display(Name = "Unidades de medida")]
        public int LogsEstadosNumber => LogsEstados == null || LogsEstados.Count == 0 ? 0 : LogsEstados.Count;
    }
}
