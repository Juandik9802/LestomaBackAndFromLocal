using LocalBackend.Controllers;
using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Cultivo;
using Microsoft.AspNetCore.Mvc;

namespace Lestoma.Backend.Controllers.Cultivos
{
    [ApiController]
    [Route("/api/[controller]")]
    public class TipoCultivoController : GenericController<ClsMTipoCultivo>
    {
        public TipoCultivoController(IGenericUnitOfWork<ClsMTipoCultivo> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
