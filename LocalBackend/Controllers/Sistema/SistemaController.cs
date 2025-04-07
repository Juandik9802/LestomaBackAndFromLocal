using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Sistema;
using LocalShared.DTOs;
using LocalShared.Entities.Sistemas;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Sistema
{
    [ApiController]
    [Route("api/[controller]")]
    public class SistemaController : GenericController<ClsMSistema>
    {
        private readonly ISistemaUnitOfWork _sistemaUnitOfWork;

        public SistemaController(IGenericUnitOfWork<ClsMSistema> unitOfWork, ISistemaUnitOfWork sistemaUnitOfWork) : base(unitOfWork)
        {
            _sistemaUnitOfWork = sistemaUnitOfWork;
        }

        [HttpGet("full")]
        public override async Task<IActionResult> GetAsync()
        {
            var responce = await _sistemaUnitOfWork.GetAsync();
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return BadRequest();
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync(PaginationDTO pagination)
        {
            var response = await _sistemaUnitOfWork.GetAsync(pagination);
            if (response.WasSuccess)
            {
                return Ok(response.Result);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(Guid Id)
        {
            var responce = await _sistemaUnitOfWork.GetAsync(Id);
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return NotFound(responce.Message);
        }
    }
}
