using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    public class ClienteEntityTypeConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("clienteId");

            builder.OwnsOne(x => x.Nombres)
               .Property(x => x.Value)
               .HasColumnName("nombres")
               .IsRequired();

            builder.OwnsOne(x => x.Apellidos)
                .Property(x => x.Value)
                .HasColumnName("apellidos")
                .IsRequired();

            builder.OwnsOne(x => x.Telefono)
                .Property(x => x.Value)
                .HasColumnName("telefono")
                .IsRequired();

            builder.OwnsOne(x => x.Correo)
                .Property(x => x.Value)
                .HasColumnName("correo")
                .IsRequired();

            builder
                .Property(x => x.Direccion)
                .HasColumnName("direccion")
                .IsRequired();
        }
    }
}
