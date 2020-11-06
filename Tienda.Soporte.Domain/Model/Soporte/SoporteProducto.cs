using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class SoporteProducto : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public Model.Soporte.Soporte Soporte { get; set; }
        public Producto Producto { get; set; }

        public SoporteProducto(Soporte soporte, Producto producto)
        {
            Soporte = soporte;
            Producto = producto;
        }

        protected SoporteProducto() { }
    }
}
