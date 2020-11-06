using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.SharedKernel.ValueObjects.Descripcion.Rules
{
    public class DescripcionRule : IBusinessRule
    {
        private readonly string _value;

        public DescripcionRule(string value)
        {
            _value = value;
        }

        public string Message => "La descripción no debe exceder los 300 caractéres";

        public bool IsBroken() => _value.Length > 300;
    }
}
