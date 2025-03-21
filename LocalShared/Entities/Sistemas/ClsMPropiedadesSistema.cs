using LocalShared.Entities.Medicion;
using LocalShared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Sistemas
{
    public class ClsMPropiedadesSistema:IEntityWithName
    {
        [Key]
        public Guid IdPropiedadSistema { get; set; }
        public Guid? AsignacionSistemaId { get; set; }
        public ClsMAsignacionSistema? AsignacionSistema { get; set; }

        [Display(Name = "Nombre del Atributo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }
        public float Valor { get; set; }
        public Guid? UnidadMedidaId { get; set; }
        public ClsMUnidadMedida UnidadMedida { get; set; }
        public int CantidadAtributo { get; set; }
    }
}
