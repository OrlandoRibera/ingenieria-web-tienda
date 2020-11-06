using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Distribucion.Infraestructura.Persistence;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence.Repository;

namespace Tienda.Soporte.Infraestructura.Persistence.Repository
{
    public class TecnicoRepository : ITecnicoRepository
    {
        private readonly ApplicationDbContext _context;

        public TecnicoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Tecnico> GetTecnico(Guid tecnicoId)
        {
            Tecnico obj =
                await _context.Tecnico.Where(o => o.Id == tecnicoId).FirstOrDefaultAsync();
            return obj;
        }

        public async Task Insert(Tecnico tecnico)
        {
            await _context.Tecnico.AddAsync(tecnico);
        }
    }
}
