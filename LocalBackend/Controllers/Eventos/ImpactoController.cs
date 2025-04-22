using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.implementation;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalShared.DTOs.Eventos;
using LocalShared.Entities.Auditoria;
using LocalShared.Entities.Eventos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Eventos
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImpactoController : GenericController<ClsMImpacto,ImpactoDTO>
    {
        private readonly IImpactoUnitOfWork _impactoUnitOfWork;
        public ImpactoController(IGenericUnitOfWork<ClsMImpacto> unitOfWork, IImpactoUnitOfWork impactoUnitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _impactoUnitOfWork = impactoUnitOfWork;
        }

        [HttpGet]
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
