using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Mediciones;
using LocalShared.DTOs.Medicion;
using LocalShared.Entities.Medicion;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Medicion
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnidadMedidaController : GenericController<ClsMUnidadMedida,UnidadMedidaDTO>
    {
        private readonly IUnidadMedidaUnitOfWork _unidadMedidaUnitOfWork;

        public UnidadMedidaController(IGenericUnitOfWork<ClsMUnidadMedida> unitOfWork, IUnidadMedidaUnitOfWork unidadMedidaUnitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _unidadMedidaUnitOfWork = unidadMedidaUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync()
        {
            var responce = await _unidadMedidaUnitOfWork.GetAsync();
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(Guid Id)
        {
            var responce = await _unidadMedidaUnitOfWork.GetAsync(Id);
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return NotFound(responce.Message);
        }
    }
}
