using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Elemento;
using LocalShared.DTOs;
using LocalShared.Entities.Elementos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Elementos
{
    [ApiController]
    [Route("api/[controller]")]
    public class ElementoController : GenericController<ClsMElemento>
    {
        private readonly IElementoUnitOfWork _elementosUnitOfWork;

        public ElementoController(IGenericUnitOfWork<ClsMElemento> unitOfWork, IElementoUnitOfWork elementosUnitOfWork) : base(unitOfWork)
        {
            _elementosUnitOfWork = elementosUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync([FromQuery] PaginationDTO pagination)
        {
            var response = await _elementosUnitOfWork.GetAsync(pagination);
            if (response.WasSuccess)
            {
                return Ok(response.Result);
            }
            return BadRequest();
        }

        [HttpGet("totalPages")]
        public override async Task<IActionResult> GetPagesAsync([FromQuery] PaginationDTO pagination)
        {
            var response = await _elementosUnitOfWork.GetAsync(pagination);
            if (response.WasSuccess)
            {
                return Ok(response.Result);
            }
            return BadRequest();
        }

        [HttpGet("full")]
        public override async Task<IActionResult> GetAsync()
        {
            var responce = await _elementosUnitOfWork.GetAsync();
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(Guid Id)
        {
            var responce = await _elementosUnitOfWork.GetAsync(Id);
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return NotFound(responce.Message);
        }
    }
}