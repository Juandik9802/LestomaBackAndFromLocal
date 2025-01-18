using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Cultivo
{
    public class ClsMTipoCultivo
    {
        [Key]
        [Display(Name = "Identificador unico del cultivo")]
        public Guid TipCltId { get; set; }

        [Display(Name = "Nombre del tipo de cultivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Column(TypeName = "varchar(30)")]
        public string? TipCltNombre { get; set; }

        [Display(Name = "Descripcion del cultivo")]
        [Column(TypeName = "varchar(50)")]
        public string? TipCltDescripcion { get; set; }

        [Display(Name = "Identificador del usuario")]
        public Guid? TipCltUsrId { get; set; }

        [Display(Name = "Fecha y hora de la modificacion")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateTime? TipCltDtUtmModificacion { get; set; }

        [Display(Name = "Identificador unico del estado del cultivo")]
        public Guid? TipCltStdCultivo { get; set; }
    }
}
