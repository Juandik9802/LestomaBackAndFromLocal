using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Eventos;
using LocalShared.Entities.Eventos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Eventos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoEventoController : GenericController<ClsMTipoEvento,TipoEventoDTO>
    {
        private readonly ITipoEventoUnitOfWork _tipoEventoUnitOfWork;

        public TipoEventoController(IGenericUnitOfWork<ClsMTipoEvento> unitOfWork, ITipoEventoUnitOfWork tipoEventoUnitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _tipoEventoUnitOfWork = tipoEventoUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync()
        {
            var responce = await _tipoEventoUnitOfWork.GetAsync();
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(Guid Id)
        {
            var responce = await _tipoEventoUnitOfWork.GetAsync(Id);
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return NotFound(responce.Message);
        }
    }
}
