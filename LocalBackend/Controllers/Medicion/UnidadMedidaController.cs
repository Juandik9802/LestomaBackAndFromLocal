using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Mediciones;
using LocalShared.DTOs;
using LocalShared.Entities.Medicion;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Medicion
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnidadMedidaController : GenericController<ClsMUnidadMedida>
    {
        private readonly IUnidadMedidaUnitOfWork _unidadMedidaUnitOfWork;

        public UnidadMedidaController(IGenericUnitOfWork<ClsMUnidadMedida> unitOfWork, IUnidadMedidaUnitOfWork unidadMedidaUnitOfWork) : base(unitOfWork)
        {
            _unidadMedidaUnitOfWork = unidadMedidaUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync([FromQuery] PaginationDTO pagination)
        {
            var response = await _unidadMedidaUnitOfWork.GetAsync(pagination);
            if (response.WasSuccess)
            {
                return Ok(response.Result);
            }
            return BadRequest();
        }

        [HttpGet("totalPages")]
        public override async Task<IActionResult> GetPagesAsync([FromQuery] PaginationDTO pagination)
        {
            var response = await _unidadMedidaUnitOfWork.GetAsync(pagination);
            if (response.WasSuccess)
            {
                return Ok(response.Result);
            }
            return BadRequest();
        }

        [HttpGet("full")]
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
