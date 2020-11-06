using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.SharedKernel.ValueObjects.Email
{
    public class EmailValue : ValueObject, IComparable<EmailValue>
    {
        public string Value { get; set; }

        public EmailValue(string value)
        {
            CheckRule(new NotNullRule<string>(value));
            CheckRule(new EmailRule(value));
        }

        #region Conversion

        public static implicit operator string(EmailValue value) => value.Value;

        public static implicit operator EmailValue(string value) => new EmailValue(value);

        #endregion

        public int CompareTo([AllowNull] EmailValue other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
