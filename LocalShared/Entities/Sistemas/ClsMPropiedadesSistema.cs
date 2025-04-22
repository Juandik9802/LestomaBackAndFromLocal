using LocalShared.Entities.Eventos;
using LocalShared.Entities.Medicion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalShared.Entities.Sistemas;


    [Table("PropiedadSistema")]
    public partial class ClsMPropiedadSistema
    {
        [Key]
        public Guid IdPropiedadSistema { get; set; } = Guid.NewGuid();

    public Guid IdAsignacionSistema { get; set; }

        public Guid IdAsignacionMedio { get; set; }

        [StringLength(100)]
        [Display(Name = "Nombre del Atributo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Nombre { get; set; } = null!;

        public float Valor { get; set; }

        public Guid IdUnidadMedida { get; set; }

        public int CantidadAtributo { get; set; }

        [InverseProperty("IdAtributoSistemaNavigation")]
        public virtual ICollection<ClsMEvento> Eventos { get; set; } = new List<ClsMEvento>();

        [ForeignKey("IdAsignacionMedio")]
        [InverseProperty("PropiedadSistemas")]
        public virtual ClsMAsignacionMedio IdAsignacionMedioNavigation { get; set; } = null!;

        [ForeignKey("IdAsignacionSistema")]
        [InverseProperty("PropiedadSistemas")]
        public virtual ClsMAsignacionSistema IdAsignacionSistemaNavigation { get; set; } = null!;

        [ForeignKey("IdUnidadMedida")]
        [InverseProperty("PropiedadSistemas")]
        public virtual ClsMUnidadMedida IdUnidadMedidaNavigation { get; set; } = null!;
    }



