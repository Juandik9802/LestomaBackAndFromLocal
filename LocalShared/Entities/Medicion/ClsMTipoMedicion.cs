using LocalShared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Medicion
{
    public class ClsMTipoMedicion : IEntityWithName
    {
        [Key]
        public Guid IdTipoMedicion { get; set; }
        public string? Nombre { get; set; }

        public ICollection<ClsMUnidadMedida>? UnidadMedida { get; set; }

        public int UnidadMedidaNumber => UnidadMedida == null || UnidadMedida.Count == 0 ? 0 : UnidadMedida.Count;
    }
}
