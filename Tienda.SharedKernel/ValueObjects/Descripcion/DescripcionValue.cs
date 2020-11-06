using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Tienda.SharedKernel.Core;
using Tienda.SharedKernel.ValueObjects.Descripcion.Rules;

namespace Tienda.SharedKernel.ValueObjects.Descripcion
{
    public class DescripcionValue : ValueObject, IComparable<DescripcionValue>
    {
        public string Value { get; private set; }

        public DescripcionValue(string value)
        {
            CheckRule(new NotNullRule<string>(value));
            CheckRule(new DescripcionRule(value));

            Value = value;
        }


        #region Conversion

        public static implicit operator string(DescripcionValue value) => value.Value;

        public static implicit operator DescripcionValue(string value) => new DescripcionValue(value);

        #endregion

        public int CompareTo([AllowNull] DescripcionValue other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
