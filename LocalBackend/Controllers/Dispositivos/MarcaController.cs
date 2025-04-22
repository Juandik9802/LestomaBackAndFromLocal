using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Dispositivos;
using LocalShared.Entities.Auditoria;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarcaController : GenericController<ClsMMarca,MarcaDTO>
    {
        public MarcaController(IGenericUnitOfWork<ClsMMarca> unitOfWork, IMapper mapper)
            : base(unitOfWork, mapper)
        {
        }
    }
}
