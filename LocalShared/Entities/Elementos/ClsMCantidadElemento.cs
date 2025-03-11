using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Elementos
{
    public class ClsMCantidadElemento
    {
        [Key]
        [Display (Name ="Identificador unico de cantidad por elemento")]
        public Guid IdCatidadElemento { get; set; }
        public Guid IdElemento { get; set; }
        public Guid IdAsignacionSistema { get; set; }
        public float Cantidad { get; set; }
        public Guid IdUnidadMedida { get; set; }

    }
}
