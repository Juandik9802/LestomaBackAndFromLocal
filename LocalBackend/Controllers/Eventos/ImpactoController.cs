using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs;
using LocalShared.Entities.Eventos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Eventos
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImpactoController : GenericController<ClsMImpacto>
    {
        private readonly IImpactoUnitOfWork _impactoUnitOfWork;

        public ImpactoController(IGenericUnitOfWork<ClsMImpacto> unitOfWork, IImpactoUnitOfWork impactoUnitOfWork) : base(unitOfWork)
        {
            _impactoUnitOfWork = impactoUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync(PaginationDTO pagination)
        {
            var response = await _impactoUnitOfWork.GetAsync(pagination);
            if (response.WasSuccess)
            {
                return Ok(response.Result);
            }
            return BadRequest();
        }

        [HttpGet("full")]
        public override async Task<IActionResult> GetAsync()
        {
            var responce = await _impactoUnitOfWork.GetAsync();
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(Guid Id)
        {
            var responce = await _impactoUnitOfWork.GetAsync(Id);
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return NotFound(responce.Message);
        }
    }
}
