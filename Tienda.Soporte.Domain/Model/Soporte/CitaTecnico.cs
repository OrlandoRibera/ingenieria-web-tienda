using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class CitaTecnico : Entity
    {
        public Guid Id { get; private set; }
        public Cita Cita { get; private set; }
        public Tecnico Tecnico { get; private set; }

        public CitaTecnico(
            Cita cita,
            Tecnico tecnico)
        {
            Cita = cita;
            Tecnico = tecnico;
        }
    }
}
