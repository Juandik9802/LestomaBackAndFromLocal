using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Auditoria;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Auditoria
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuditoriaController : GenericController<ClsMAuditoria>
    {
        public AuditoriaController(IGenericUnitOfWork<ClsMAuditoria> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
