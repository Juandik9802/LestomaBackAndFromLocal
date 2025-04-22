using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Medicion;
using LocalShared.Entities.Medicion;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Medicion
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicionController : GenericController<ClsMMedicion,MedicionDTO>
    {
        public MedicionController(IGenericUnitOfWork<ClsMMedicion> unitOfWork, IMapper mapper) : base(unitOfWork,mapper)
        {
        }
    }
}
