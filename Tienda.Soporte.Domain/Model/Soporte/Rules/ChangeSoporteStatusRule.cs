using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Domain.Model.Rules
{
    public class ChangeSoporteStatusRule : IBusinessRule
    {
        private readonly EstadoSoporte oldStatus;
        private readonly EstadoSoporte newStatus;

        public ChangeSoporteStatusRule(EstadoSoporte oldStatus, EstadoSoporte newStatus)
        {
            this.oldStatus = oldStatus;
            this.newStatus = newStatus;
        }

        public string Message => "No se puede cambiar del estado " + oldStatus.ToString() +
            " al estado " + newStatus.ToString();

        public bool IsBroken()
        {
            if (newStatus == EstadoSoporte.Finaliado && oldStatus != EstadoSoporte.Pendiente)
            {
                return true;
            }
            return false;
        }
    }
}
