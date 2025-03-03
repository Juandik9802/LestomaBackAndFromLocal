using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Medicion
{
    public class ClsMUnidadMedida
    {
        [Key]
        public Guid IdUnidadMedida { get; set; }

        public Guid TipoMedicionId { get; set; }
        public ClsMTipoMedicion? TipoMedicion { get; set; }

        [Required]
        public string? Nombre { get; set; }

        public string? Simbolo { get; set; }

        public ICollection<ClsMMedicion> Mediciones { get; set; }
    }
}
