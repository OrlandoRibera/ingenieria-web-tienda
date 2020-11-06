using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tienda.Soporte.Infraestructura.Persistence;
using Tienda.Soporte.Domain.Persistence.Repository;

namespace Tienda.Soporte.Infraestructura.Persistence.Repository
{
    public class SoporteRepository : ISoporteRepository
    {
        private readonly ApplicationDbContext _context;

        public SoporteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Cancel(Domain.Model.Soporte.Soporte soporte)
        {
            soporte.AnularSoporte();
            _context.Soporte.Update(soporte);
        }

        public async Task<List<Domain.Model.Soporte.Soporte>> GetAll()
        {
            return await _context.Soporte.ToListAsync();
        }

        public async Task<Domain.Model.Soporte.Soporte> GetByID(Guid id)
        {
            return await _context.Soporte.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Insert(Domain.Model.Soporte.Soporte soporte)
        {
            await _context.Soporte.AddAsync(soporte);
        }
    }
}
