using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Domain.Persistence.Repository
{
    public interface ISoporteProductoRepository
    {
        Task Insert(SoporteProducto soporteProducto);
        Task<SoporteProducto> GetSoporteProducto(Guid id);
    }
}
