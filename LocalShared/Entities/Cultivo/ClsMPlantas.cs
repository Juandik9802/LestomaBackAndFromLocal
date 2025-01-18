using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Cultivo
{
    public class ClsMPlantas
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid PltId { get; set; }

        [Display(Name = "Nombre de la planta")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? PltNombre { get; set; }

        [Display(Name = "Identificador del usuario que modifico")]
        public Guid? PltUsrId { get; set; }

        [Display(Name = "Identificador del estado de la planta")]



        public Guid? PltStdId { get; set; }

        [Display(Name = "Fecha y hora de la modificacion")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateTime? PltDtUtmModificacion { get; set; }

    }
}
