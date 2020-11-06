using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Infraestructura.Persistence;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence.Repository;

namespace Tienda.Soporte.Infraestructura.Persistence.Repository
{
    public class CitaRepository : ICitaRepository
    {
        private readonly ApplicationDbContext _context;

        public CitaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cita>> GetAll()
        {
            return await _context.Cita.ToListAsync();
        }

        public async Task<Cita> GetByID(Guid citaId)
        {
            return await _context.Cita.Where(x => x.Id == citaId).FirstOrDefaultAsync();
        }

        public async Task<List<CitaTecnico>> GetCitasTecnico(Guid tecnicoId)
        {
            return await _context.CitaTecnico.Where(x => x.Tecnico.Id == tecnicoId).ToListAsync();
        }

        public async Task Insert(Guid soporteId, string descripcion, string direccion, DateTime fechaPrevista)
        {
            Domain.Model.Soporte.Soporte soporte = await _context.Soporte.Where(x => x.Id == soporteId).FirstOrDefaultAsync();
            Cita cita = new Cita(soporte, fechaPrevista, direccion, descripcion);
            await _context.Cita.AddAsync(cita);
        }

        public async Task InsertCitaTecnico(CitaTecnico citaTecnico)
        {
            await _context.AddAsync(citaTecnico);
        }
    }
}
