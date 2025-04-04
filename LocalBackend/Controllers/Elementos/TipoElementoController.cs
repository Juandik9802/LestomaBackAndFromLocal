using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Elemento;
using LocalShared.Entities.Elementos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Elementos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoElementoController : GenericController<ClsMTipoElemento>
    {
        private readonly ITipoElementoUnitOfWork _tipoElementoUnitOfWork;

        public TipoElementoController(IGenericUnitOfWork<ClsMTipoElemento> unitOfWork, ITipoElementoUnitOfWork tipoElementoUnitOfWork): base(unitOfWork)
        {
            _tipoElementoUnitOfWork = tipoElementoUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync()
        {
            var responce = await _tipoElementoUnitOfWork.GetAsync();
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(Guid Id)
        {
            var responce = await _tipoElementoUnitOfWork.GetAsync(Id);
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return NotFound(responce.Message);
        }
    }
}
