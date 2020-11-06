using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Soporte.Domain.Persistence.Repository
{
    public interface ISoporteRepository
    {
        Task Insert(Model.Soporte.Soporte soporte);
        Task<Model.Soporte.Soporte> GetByID(Guid id);
        Task<List<Model.Soporte.Soporte>> GetAll();
        void Cancel(Model.Soporte.Soporte soporte);
    }
}
