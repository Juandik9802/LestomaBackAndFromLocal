using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Elementos;
using LocalShared.Entities.Auditoria;
using LocalShared.Entities.Elementos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Elementos
{
    [ApiController]
    [Route("api/[controller]")]
    public class CantidadElementoController : GenericController<ClsMCantidadElemento,CantidadElementoDTO>
    {
        public CantidadElementoController(IGenericUnitOfWork<ClsMCantidadElemento> unitOfWork, IMapper mapper)
            : base(unitOfWork, mapper)
        {
        }
    }
}
