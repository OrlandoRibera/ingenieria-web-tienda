using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tienda.Soporte.Domain.Persistence;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence.Repository;
using Tienda.Soporte.Web.ViewModel;

namespace Tienda.Soporte.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly ICitaRepository _citaRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITecnicoRepository _tecnicoRepository;
        private readonly ISoporteRepository _soporteRepository;

        public CitaController(ICitaRepository citaRepository, IUnitOfWork unitOfWork, ITecnicoRepository tecnicoRepository, ISoporteRepository soporteRepository)
        {
            _citaRepository = citaRepository;
            _unitOfWork = unitOfWork;
            _tecnicoRepository = tecnicoRepository;
            _soporteRepository = soporteRepository;
        }

        [HttpPost]
        public async Task<IActionResult> InsertCita([FromBody] CitaViewModel citaViewModel)
        {
            await _citaRepository.Insert(citaViewModel.SoporteId, citaViewModel.Direccion, citaViewModel.Descripcion, citaViewModel.FechaPrevista);
            await _unitOfWork.Commit();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Cita> citas = await _citaRepository.GetAll();
            return Ok(new { citas });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            Cita cita = await _citaRepository.GetByID(id);
            return Ok(new { cita });
        }

    }
}
