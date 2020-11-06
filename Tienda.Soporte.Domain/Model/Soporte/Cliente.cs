using System;
using Tienda.SharedKernel.Core;
using Tienda.SharedKernel.ValueObjects;
using Tienda.SharedKernel.ValueObjects.Email;
using Tienda.SharedKernel.ValueObjects.PhoneNumber;


namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class Cliente : Entity
    {
        public Guid Id { get; private set; }

        public PersonNameValue Nombres { get; private set; }
        public PersonNameValue Apellidos { get; private set; }
        public PhoneNumberValue Telefono { get; private set; }
        public EmailValue Correo { get; private set; }
        public string Direccion { get; private set; }

        public Cliente(
            string nombres,
            string apellidos,
            string telefono,
            string correo,
            string direccion
            )
        {
            Id = Guid.NewGuid();
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }

        protected Cliente() { }
    }
}
