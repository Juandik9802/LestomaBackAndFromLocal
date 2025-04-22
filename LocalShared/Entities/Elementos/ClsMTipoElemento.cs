using LocalShared.Entities.Sistemas;
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

namespace LocalShared.Entities.Elementos;

    [Table("TipoElemento")]
    [Index("Nombre", Name = "IX_TipoElemento_Nombre", IsUnique = true)]
    public partial class ClsMTipoElemento
    {
        [Key]
        public Guid IdTipoElemento { get; set; } = Guid.NewGuid();

    [StringLength(10)]
        [Display(Name = "Tipo de dispositivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Nombre { get; set; } = null!;

        [InverseProperty("IdTipoElementoNavigation")]
        public virtual ICollection<ClsMAsignacionMedio> AsignacionMedios { get; set; } = new List<ClsMAsignacionMedio>();

        [InverseProperty("IdTipoElementoNavigation")]
        public virtual ICollection<ClsMElemento> Elementos { get; set; } = new List<ClsMElemento>();
    }


