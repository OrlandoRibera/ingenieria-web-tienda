using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Domain.Persistence.Repository
{
    public interface IClienteRepository
    {
        Task Insert(Cliente cliente);
        Task<Cliente> GetByID(Guid id);
        Task<List<Cliente>> GetAll();
    }
}
