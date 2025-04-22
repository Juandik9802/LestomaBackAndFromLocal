using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Sistemas;
using LocalShared.DTOs.Usuarios;
using LocalShared.Entities.Sistemas;
using LocalShared.Entities.Usuarios;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Usuarios
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : GenericController<ClsMUsuario, UsuarioDTO>
    {
        public UsuarioController(IGenericUnitOfWork<ClsMUsuario> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
