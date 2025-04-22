using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Usuarios;
using LocalShared.Entities.Usuarios;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Usuarios
{
    [ApiController]
    [Route("api/[controller]")]
    public class SesionUsuarioController : GenericController<ClsMSesionUsuario, SesionUsuarioDTO>
    {
        public SesionUsuarioController(IGenericUnitOfWork<ClsMSesionUsuario> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
