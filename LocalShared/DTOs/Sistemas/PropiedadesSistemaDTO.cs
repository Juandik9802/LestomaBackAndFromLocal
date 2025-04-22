using System.ComponentModel.DataAnnotations;

namespace LocalShared.DTOs.Sistemas
{
    public class PropiedadesSistemaDTO
    {
        [Key]
        public Guid IdPropiedadSistema { get; set; } = Guid.NewGuid();
        public Guid IdAsignacionSistema { get; set; }
        public Guid IdTipoAtributo { get; set; }

        [Display(Name = "Nombre del Atributo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }
        public float Valor { get; set; }
        public Guid IdUnidadMedida { get; set; }
        public int CantidadAtributo { get; set; }
    }
}
