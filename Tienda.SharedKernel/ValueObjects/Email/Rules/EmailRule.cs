using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Tienda.SharedKernel.Core
{
    class EmailRule : IBusinessRule
    {
        private readonly string _value;

        public EmailRule(string value)
        {
            this._value = value;
        }

        public string Message => "No es un email válido";

        public bool IsBroken() => !IsValid(this._value);

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
