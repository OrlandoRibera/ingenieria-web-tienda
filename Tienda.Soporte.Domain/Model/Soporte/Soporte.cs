using System;
using Tienda.SharedKernel.Core;
using Tienda.SharedKernel.ValueObjects.Descripcion;
using Tienda.Soporte.Domain.Model.Rules;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class Soporte : Entity
    {
        public Guid Id { get; private set; }
        public Cliente Cliente { get; private set; }
        public DescripcionValue Descripcion { get; private set; }
        public decimal Costo { get; private set; }
        public EstadoSoporte Estado { get; set; }
        public DateTime FechaCreacion { get; private set; }
        public DateTime? FechaCulminacion { get; private set; }
        public DateTime? FechaAnulacion { get; private set; }

        public Soporte(
            Cliente cliente,
            string descripcion,
            decimal costo
            )
        {
            Id = Guid.NewGuid();
            Cliente = cliente;
            Descripcion = descripcion;
            Costo = costo;
            Estado = EstadoSoporte.Pendiente;
            FechaCreacion = DateTime.Now;
        }

        protected Soporte() { }

        public void FinalizarSoporte()
        {
            CheckRule(new ChangeSoporteStatusRule(Estado, EstadoSoporte.Finaliado));
            Estado = EstadoSoporte.Finaliado;
            FechaCulminacion = DateTime.Now;
        }

        public void AnularSoporte()
        {
            Estado = EstadoSoporte.Anulado;
            FechaAnulacion = DateTime.Now;
        }


    }
}
