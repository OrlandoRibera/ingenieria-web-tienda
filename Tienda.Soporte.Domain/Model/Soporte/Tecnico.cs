using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.ValueObjects;
using Tienda.SharedKernel.ValueObjects.Email;
using Tienda.SharedKernel.ValueObjects.PhoneNumber;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class Tecnico
    {
        public Guid Id { get; private set; }
        public PersonNameValue Nombres { get; private set; }
        public PersonNameValue Apellidos { get; private set; }
        public string Ci { get; private set; }
        public string Profesion { get; private set; }
        public PhoneNumberValue Telefono { get; private set; }
        public EmailValue Correo { get; private set; }

        public Tecnico(
            string nombres,
            string apellidos,
            string ci,
            string profesion,
            string telefono,
            string correo)
        {
            Id = Guid.NewGuid();
            Nombres = nombres;
            Apellidos = apellidos;
            Ci = ci;
            Profesion = profesion;
            Telefono = telefono;
            Correo = correo;
        }

        protected Tecnico() { }
    }
}
