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
    public class SoporteProductoRepository : ISoporteProductoRepository
    {
        private readonly ApplicationDbContext _context;

        public SoporteProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<SoporteProducto> GetSoporteProducto(Guid id)
        {
            SoporteProducto obj = await _context.SoporteProducto.Where(x => x.Id == id).FirstOrDefaultAsync();
            return obj;
        }

        public async Task Insert(SoporteProducto soporteProducto)
        {
            await _context.SoporteProducto.AddAsync(soporteProducto);
        }
    }
}
