using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tienda.Distribucion.Domain.Persistence;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence.Repository;
using Tienda.Soporte.Web.ViewModel;

namespace Tienda.Soporte.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenServicioController : ControllerBase
    {
        private readonly ISoporteRepository _soporteRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClienteRepository _clienteRepository;

        public OrdenServicioController(ISoporteRepository soporteRepository,
            IUnitOfWork unitOfWork, IClienteRepository clienteRepository)
        {
            _soporteRepository = soporteRepository;
            _unitOfWork = unitOfWork;
            _clienteRepository = clienteRepository;
        }

        [HttpPost]
        [Route("api/[controller]")]
        public async Task<IActionResult> Insert([FromBody] SoporteViewModel soporte, string desc, decimal costo)
        {
            try
            {
                Cliente objCliente = await _clienteRepository.GetByID(soporte.Cliente);
                Soporte.Domain.Model.Soporte.Soporte obj = new Soporte.Domain.Model.Soporte.Soporte(
                    objCliente, desc, costo
                    );
                await _soporteRepository.Insert(obj);
                await _unitOfWork.Commit();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
                throw e;
            }
        }

        [HttpPost]
        [Route("api/[controller]/anular")]
        public async Task<IActionResult> Anular([FromBody] Guid soporteId)
        {
            try
            {
                Domain.Model.Soporte.Soporte obj = await _soporteRepository.GetByID(soporteId);
                _soporteRepository.Cancel(obj);
                await _unitOfWork.Commit();
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
                throw;
            }
        }
    }
}
