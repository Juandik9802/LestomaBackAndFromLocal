using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Cultivo
{
    public class ClsMCultivo
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid ClvId { get; set; }

        [Display(Name = "Identificador del tipo de cultivo")]
        public Guid? ClvTpcId { get; set; }

        [Display(Name = "Identificador de la planta")]
        public Guid? ClvPltId { get; set; }

        [Display(Name = "Fecha de plantacion")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ClvFchInicio { get; set; }
        [Display(Name = "Cantidad de plantas")]
        public int? ClvCtdInicial { get; set; }

        [Display(Name = "Fecha salida de plantas")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ClvFchFin { get; set; }

        [Display(Name = "Cantidad final de plantas")]
        public int? ClvCtdFinal { get; set; }

        [Display(Name = "Identificador de UPA")]
        public Guid? ClvUpsId { get; set; }

        [Display(Name = "Identificador unico del usuario que modifica")]
        public Guid? ClvUsrId { get; set; }

        [Display(Name = "Identificador unico del estdo del cultivo")]
        public Guid? ClvStdId { get; set; }

        [Display(Name = "Fecha y hora de la modificacion")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateTime? ClvDtUtmModificacion { get; set; }

    }
}
