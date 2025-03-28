﻿using LocalShared.Entities.Sistemas;
using LocalShared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Dispositivos
{
    public class ClsMDispositivo : IEntityWithName
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid IdDispositivo { get; set; }

        [Display(Name = "Nombre del dispositivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string? Nombre { get; set; }
        public Guid? AsignacionSistemaId { get; set; }
        public ClsMAsignacionSistema? AsignacionSistema { get; set; }
        public Guid? TipoDispositivoId { get; set; }
        public ClsMTipoDispositivo? TipoDispositivo { get; set; }

        //[Required]
        public Guid? MarcaId { get; set; }
        public ClsMMarca? Marca { get; set; }
        public string? SN { get; set; }
        public string? Descripcion { get; set; }

        public ICollection<ClsMLogsEstado>? LogsEstados { get; set; }

        [Display(Name = "Registro de estados")]
        public int LogsEstadosNumber => LogsEstados == null || LogsEstados.Count == 0 ? 0 : LogsEstados.Count;

        public ICollection<ClsMPuntoOptimo>?  puntoOptimos { get; set; }

        [Display(Name = "Registro de estados")]
        public int PuntosOptimosNumber => puntoOptimos == null || puntoOptimos.Count == 0 ? 0 : puntoOptimos.Count;
    }
}
