﻿using LocalBackend.Repositories.UnitsOfWork.implementation.Dispositivo;
using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos;
using LocalShared.DTOs;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Dispositivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarcaController : GenericController<ClsMMarca>
    {
        private readonly IMarcaUnitOfWork _marcaUnitOfWork;

        public MarcaController(IGenericUnitOfWork<ClsMMarca> unitOfWork, IMarcaUnitOfWork marcaUnitOfWork) : base(unitOfWork)
        {
            _marcaUnitOfWork = marcaUnitOfWork;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync(PaginationDTO pagination)
        {
            var response = await _marcaUnitOfWork.GetAsync(pagination);
            if (response.WasSuccess)
            {
                return Ok(response.Result);
            }
            return BadRequest();
        }

        [HttpGet("full")]
        public override async Task<IActionResult> GetAsync()
        {
            var responce = await _marcaUnitOfWork.GetAsync();
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(Guid Id)
        {
            var responce = await _marcaUnitOfWork.GetAsync(Id);
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return NotFound(responce.Message);
        }
    }
}
