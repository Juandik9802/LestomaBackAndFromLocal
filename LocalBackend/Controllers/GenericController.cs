using AutoMapper;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers
{
    public class GenericController<TEntity, TDto> : Controller where TEntity : class
    {
        private readonly IGenericUnitOfWork<TEntity> _unitOfWork;
        private readonly IMapper _mapper;

        public GenericController(IGenericUnitOfWork<TEntity> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAsync()
        {
            var action = await _unitOfWork.GetAsync();

            if (action.WasSuccess)
            {   

                var dtos = _mapper.Map<IEnumerable<TDto>>(action.Result);
                return Ok(dtos);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetAsync(Guid id)
        {
            var action = await _unitOfWork.GetAsync(id);
            if (action.WasSuccess)
            {
                var dto = _mapper.Map<TDto>(action.Result);
                return Ok(dto);
            }
            return NotFound();
        }

        [HttpPost]
        public virtual async Task<IActionResult> PostAsync([FromBody] TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            var action = await _unitOfWork.AddAsync(entity);
            if (action.WasSuccess)
            {
                var resultDto = _mapper.Map<TDto>(action.Result);
                return Ok(resultDto);
            }
            return BadRequest(action.Message);
        }

        [HttpPut]
        public virtual async Task<IActionResult> PutAsync([FromBody] TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            var action = await _unitOfWork.UpdateAsync(entity);
            if (action.WasSuccess)
            {
                var resultDto = _mapper.Map<TDto>(action.Result);
                return Ok(resultDto);
            }
            return BadRequest(action.Message);
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteAsync(Guid id)
        {
            var action = await _unitOfWork.DeleteAsync(id);
            if (action.WasSuccess)
            {
                return NoContent();
            }
            return BadRequest(action.Message);
        }
    }
}
