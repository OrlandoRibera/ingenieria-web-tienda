using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class Producto : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public string Categoria { get; private set; }

        public Producto(string nombre, string categoria)
        {
            CheckRule(new NotNullRule<string>(nombre));
            CheckRule(new NotNullRule<string>(categoria));
            Id = Guid.NewGuid();
            Nombre = nombre;
            Categoria = categoria;
        }
    }
}
