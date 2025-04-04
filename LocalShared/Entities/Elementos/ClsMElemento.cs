using LocalShared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Elementos
{
    public class ClsMElemento:IEntityWithName
    {
        [Key]
        [Display(Name ="Identificador del elemento")]
        public Guid IdElemento { get; set; }        

        public Guid? TipoElementoId { get; set; }
        public ClsMTipoElemento? TipoElemento { get; set; }

        [Display(Name = "Nombre del elemento")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }

        public ICollection<ClsMCantidadElemento>? CantidadElementos { get; set; }
        public int CantidadElementosNumber => CantidadElementos == null || CantidadElementos.Count == 0 ? 0 : CantidadElementos.Count;
    }
}
