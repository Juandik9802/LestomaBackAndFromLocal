using LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class DispositivoController : GenericController<ClsMDispositivo>
    {
        private readonly IDispositivoUnitOfWork _dispositivoUnitOfWork;

        public DispositivoController(IGenericUnitOfWork<ClsMDispositivo> unitOfWork, IDispositivoUnitOfWork dispositivoUnitOfWork) : base(unitOfWork)
        {
            _dispositivoUnitOfWork = dispositivoUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync()
        {
            var responce = await _dispositivoUnitOfWork.GetAsync();
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(Guid Id)
        {
            var responce = await _dispositivoUnitOfWork.GetAsync(Id);
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return NotFound(responce.Message);
        }
    }
}
