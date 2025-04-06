using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Medio;
using LocalShared.Entities.Sistemas;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Sistema
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedioController : GenericController<ClsMMedio>
    {
        private readonly IMedioUnitOfWork _medioUnitOfWork;

        public MedioController(IGenericUnitOfWork<ClsMMedio> unitOfWork, IMedioUnitOfWork medioUnitOfWork) : base(unitOfWork)
        {
            _medioUnitOfWork = medioUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync()
        {
            var responce = await _medioUnitOfWork.GetAsync();
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(Guid Id)
        {
            var responce = await _medioUnitOfWork.GetAsync(Id);
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return NotFound(responce.Message);
        }
    }
}
