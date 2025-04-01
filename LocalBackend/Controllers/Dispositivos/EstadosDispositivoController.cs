using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstadosDispositivoController : GenericController<ClsMEstadosDispositivo>
    {
        private readonly IEstadosDispositivoUnitOfWork _estadosDispositivoUnitOfWork;

        public EstadosDispositivoController(IGenericUnitOfWork<ClsMEstadosDispositivo> unitOfWork, IEstadosDispositivoUnitOfWork estadosDispositivoUnitOfWork) : base(unitOfWork)
        {
            _estadosDispositivoUnitOfWork = estadosDispositivoUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync()
        {
            var responce = await _estadosDispositivoUnitOfWork.GetAsync();
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(Guid Id)
        {
            var responce = await _estadosDispositivoUnitOfWork.GetAsync(Id);
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return NotFound(responce.Message);
        }

    }
}
