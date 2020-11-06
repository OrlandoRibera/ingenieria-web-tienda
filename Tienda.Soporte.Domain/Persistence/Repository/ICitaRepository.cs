using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Domain.Persistence.Repository
{
    public interface ICitaRepository
    {
        Task Insert(Guid soporteId, string descripcion, string direccion, DateTime fechaPrevista);
        Task InsertCitaTecnico(CitaTecnico citaTecnico);
        Task<Cita> GetByID(Guid citaId);
        Task<List<CitaTecnico>> GetCitasTecnico(Guid tecnicoId);
        Task<List<Cita>> GetAll();

    }
}
