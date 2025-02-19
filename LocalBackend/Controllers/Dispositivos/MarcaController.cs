using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarcaController : GenericController<ClsMMarca>
    {
        public MarcaController(IGenericUnitOfWork<ClsMMarca> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
