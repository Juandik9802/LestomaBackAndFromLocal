using System.ComponentModel.DataAnnotations;

namespace LocalShared.DTOs.Elementos
{
    public class CantidadElementoDTO
    {
        [Key]
        [Display (Name ="Identificador unico de cantidad por elemento")]
        public Guid IdCatidadElemento { get; set; } = Guid.NewGuid();
        public Guid IdElemento { get; set; }
        public Guid IdAsignacionSistema { get; set; }
        public float Cantidad { get; set; }
        public Guid IdUnidadMedida { get; set; }

    }
}
