using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Eventos
{
    public class ClsMEvento
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid IdEvento { get; set; }
        public Guid IdAsignacionSitema { get; set; }
        public Guid IdElemento { get; set; }
        public Guid IdAtributoSistema { get; set; }
        public Guid IdTipoEvento { get; set; }
        public float Cantidad { get; set; }
        public Guid IdUnidadMedida { get; set; }

        [Display(Name = "Fecha y hora del evento")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaEvento { get; set; }
    }
}
