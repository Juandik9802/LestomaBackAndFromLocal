using LocalShared.Entities.Medicion;
using LocalShared.Entities.Sistemas;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Elementos
{
    public class ClsMCantidadElemento
    {
        [Key]
        [Display (Name ="Identificador unico de cantidad por elemento")]
        public Guid IdCatidadElemento { get; set; }
        public Guid? ElementoId { get; set; }
        public ClsMElemento? Elemento { get; set; }
        public Guid? AsignacionSistemaId { get; set; }
        public ClsMAsignacionSistema? AsignacionSistema { get; set; }
        public float Cantidad { get; set; }
        public Guid? UnidadMedidaId { get; set; }
        public ClsMUnidadMedida? UnidadMedida { get; set; }

    }
}
