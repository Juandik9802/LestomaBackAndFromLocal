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
    public class ElementoController : GenericController<ClsMElemento,ElementoDTO>
    {
        public ElementoController(IGenericUnitOfWork<ClsMElemento> unitOfWork, IMapper mapper)
            : base(unitOfWork, mapper)
        {
        }
    }
}
