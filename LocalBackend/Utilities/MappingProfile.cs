using AutoMapper;
using LocalShared.Entities.Auditoria;
using LocalShared.DTOs.Auditoria;
using LocalShared.Entities.Dispositivos;
using LocalShared.DTOs.Dispositivos;
using LocalShared.DTOs.Elementos;
using LocalShared.Entities.Elementos;
using LocalShared.DTOs.Eventos;
using LocalShared.Entities.Eventos;
using LocalShared.DTOs.Medicion;
using LocalShared.Entities.Medicion;
using LocalShared.DTOs.Sistemas;
using LocalShared.Entities.Sistemas;
using LocalShared.Entities.Usuarios;
using LocalShared.DTOs.Usuarios;

namespace LocalBackend.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClsMAuditoria, AuditoriaDTO>().ReverseMap();


            CreateMap<ClsMDispositivo, DispositivoDTO>().ReverseMap();
            CreateMap<ClsMEstadosDispositivo, EstadosDispositivoDTO>().ReverseMap();
            CreateMap<ClsMLogsEstado, LogsEstadoDTO>().ReverseMap();
            CreateMap<ClsMMarca, MarcaDTO>().ReverseMap();
            CreateMap<ClsMPuntoOptimo, PuntoOptimoDTO>().ReverseMap();
            CreateMap<ClsMTipoDispositivo, TipoDispositivoDTO>().ReverseMap();


            CreateMap<ClsMCantidadElemento, CantidadElementoDTO>().ReverseMap();


            // Entidad -> DTO
            CreateMap<ClsMElemento, ElementoDTO>()
                .ForMember(dest => dest.IdElemento, opt => opt.MapFrom(src => src.IdElemento))
                .ForMember(dest => dest.NombreElemento, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.IdTipoElemento, opt => opt.MapFrom(src => src.IdTipoElemento))
                .ForMember(dest => dest.TipoElemento, opt => opt.MapFrom(src => src.IdTipoElementoNavigation.Nombre))
                .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado));


            CreateMap<ElementoDTO, ClsMElemento>()
                .ForMember(dest => dest.IdElemento, opt => opt.MapFrom(src => src.IdElemento))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.NombreElemento))
                .ForMember(dest => dest.IdTipoElemento, opt => opt.MapFrom(src => src.IdTipoElemento))
                .ForMember(dest => dest.IdTipoElementoNavigation, opt => opt.Ignore()) // esto se debe cargar en el servicio
                .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado));


            CreateMap<ClsMTipoElemento, TipoElementoDTO>().ReverseMap();


            CreateMap<ClsMEvento, EventoDTO>().ReverseMap();
            CreateMap<ClsMImpacto, ImpactoDTO>().ReverseMap();
            CreateMap<ClsMTipoEvento, TipoEventoDTO>().ReverseMap();


            CreateMap<ClsMMedicion, MedicionDTO>().ReverseMap();
            CreateMap<ClsMTipoMedicion, TipoMedicionDTO>().ReverseMap();
            CreateMap<ClsMUnidadMedida, UnidadMedidaDTO>().ReverseMap();


            CreateMap<ClsMAsignacionMedio, AsignacionMedioDTO>().ReverseMap();
            CreateMap<ClsMAsignacionSistema, AsignacionSistemaDTO>().ReverseMap();
            CreateMap<ClsMMedio, MedioDTO>().ReverseMap();
            CreateMap<ClsMPropiedadSistema, PropiedadesSistemaDTO>().ReverseMap();
            CreateMap<ClsMSistema, SistemaDTO>().ReverseMap();
            CreateMap<ClsMUpa, UpaDTO>().ReverseMap();

            
            CreateMap<ClsMUsuario, UsuarioDTO>().ReverseMap();
            CreateMap<ClsMSesionUsuario, SesionUsuarioDTO>().ReverseMap();

        }
    }
}
