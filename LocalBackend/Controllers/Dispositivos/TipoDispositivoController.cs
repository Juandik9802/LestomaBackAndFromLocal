using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoDispositivoController : GenericController<ClsMTipoDispositivo>
    {
        private readonly ITipoDispositivoUnitOfWork _dispositivoUnitOfWork;

        public TipoDispositivoController(IGenericUnitOfWork<ClsMTipoDispositivo> unitOfWork, ITipoDispositivoUnitOfWork dispositivoUnitOfWork) : base(unitOfWork)
        {
            _dispositivoUnitOfWork = dispositivoUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync(PaginationDTO pagination)
        {
            var response = await _dispositivoUnitOfWork.GetAsync(pagination);
            if (response.WasSuccess)
            {
                return Ok(response.Result);
            }
            return BadRequest();
        }

        [HttpGet("full")]
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
