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
    public class TecnicoController : ControllerBase
    {
        private readonly ITecnicoRepository _tecnicoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TecnicoController(ITecnicoRepository tecnicoRepository,
            IUnitOfWork unitOfWork)
        {
            _tecnicoRepository = tecnicoRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> InsertTecnico([FromBody] TecnicoViewModel tecnico)
        {
            try
            {
                Tecnico obj = new Tecnico(
                    nombres: tecnico.Nombres,
                    apellidos: tecnico.Apellidos,
                    ci: tecnico.Ci,
                    correo: tecnico.Correo,
                    telefono: tecnico.Telefono,
                    profesion: tecnico.Pofesion
                    );
                await _tecnicoRepository.Insert(obj);
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
