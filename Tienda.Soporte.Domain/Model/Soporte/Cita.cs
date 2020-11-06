using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class Cita : Entity
    {
        public Guid Id { get; private set; }
        public Soporte Soporte { get; private set; }
        public DateTime FechaPrevista { get; private set; }
        public string Direccion { get; private set; }
        public string Descripcion { get; private set; }

        public Cita(
            Soporte soporte,
            DateTime fecha_prevista,
            string direccion,
            string descripcion
            )
        {
            Soporte = soporte;
            FechaPrevista = fecha_prevista;
            Direccion = direccion;
            Descripcion = descripcion;
        }

        protected Cita() { }

    }
}
