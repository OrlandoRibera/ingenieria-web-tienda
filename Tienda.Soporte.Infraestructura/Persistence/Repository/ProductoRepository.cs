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
    public class ProductoRepository : IProductoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Producto> GetProducto(Guid productoId)
        {
            Producto obj =
                await _context.Producto.Where(o => o.Id == productoId).FirstOrDefaultAsync();

            return obj;
        }

        public async Task Insert(Producto producto)
        {
            await _context.Producto.AddAsync(producto);
        }
    }
}
