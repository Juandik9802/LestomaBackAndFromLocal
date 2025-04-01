using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Mediciones;
using LocalShared.Entities.Medicion;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Medicion
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoMedicionController : GenericController<ClsMTipoMedicion>
    {
        private readonly ITipoMedicionUnitOfWork _tipoMedicionUnitOfWork;

        public TipoMedicionController(IGenericUnitOfWork<ClsMTipoMedicion> unitOfWork, ITipoMedicionUnitOfWork tipoMedicionUnitOfWork) : base(unitOfWork)
        {
            _tipoMedicionUnitOfWork = tipoMedicionUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync()
        {
            var responce = await _tipoMedicionUnitOfWork.GetAsync();
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(Guid Id)
        {
            var responce = await _tipoMedicionUnitOfWork.GetAsync(Id);
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return NotFound(responce.Message);
        }
    }
}
