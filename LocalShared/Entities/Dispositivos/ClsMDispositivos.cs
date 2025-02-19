using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Dispositivos
{
    public class ClsMDispositivos
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid IdDispisitivo { get; set; }

        [Display(Name = "Nombre del dispositivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }
        public Guid IdAsignacionSistema { get; set; }
        public Guid IdTipoDispositivo { get; set; }
        public Guid IdMarca { get; set; }
        public string? SN { get; set; }
        public string? Descripcion { get; set; }
    }
}
