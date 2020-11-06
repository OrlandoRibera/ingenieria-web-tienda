using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class FormTrabajo : Entity
    {
        public Guid Id { get; private set; }
        public Cita Cita { get; private set; }
        public string TrabajoRealizado { get; private set; }
        public DateTime FechaForm { get; private set; }

        public bool ClienteConfirma { get; private set; }

        public FormTrabajo(
            Cita cita,
            string trabajo_realizado,
            bool cliente_confirma
            )
        {
            Cita = cita;
            TrabajoRealizado = trabajo_realizado;
            FechaForm = DateTime.Now;
            ClienteConfirma = cliente_confirma;
        }
        public FormTrabajo()
        {

        }
    }
}
