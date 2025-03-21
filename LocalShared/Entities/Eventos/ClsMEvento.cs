using LocalShared.Entities.Elementos;
using LocalShared.Entities.Medicion;
using LocalShared.Entities.Sistemas;
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
        public Guid? AsignacionSistemaId { get; set; }
        public ClsMAsignacionSistema? AsignacionSistema { get; set; }
        public Guid? ElementoId { get; set; }
        public ClsMElemento? Elemento { get; set; }
        public Guid? PropiedadesSistemaId { get; set; }
        public ClsMPropiedadesSistema? PropiedadesSistema { get; set; }
        public Guid? TipoEventoId { get; set; }
        public ClsMTipoEvento? TipoEvento { get; set; }
        public float Cantidad { get; set; }
        public Guid? UnidadMedidaId { get; set; }
        public ClsMUnidadMedida? UnidadMedida { get; set; } 

        [Display(Name = "Fecha y hora del evento")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaEvento { get; set; }
    }
}
