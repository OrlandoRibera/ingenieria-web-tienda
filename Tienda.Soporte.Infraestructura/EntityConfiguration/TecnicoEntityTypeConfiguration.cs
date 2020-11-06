using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    public class TecnicoEntityTypeConfiguration : IEntityTypeConfiguration<Tecnico>
    {
        public void Configure(EntityTypeBuilder<Tecnico> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("tecnicoId");

            builder
                .OwnsOne(x => x.Nombres)
                .Property(x => x.Value)
                .IsRequired();

            builder
                .OwnsOne(x => x.Apellidos)
                .Property(x => x.Value)
                .IsRequired();

            builder
                .Property(x => x.Ci)
                .IsRequired();

            builder
                .Property(x => x.Profesion)
                .IsRequired();

            builder
                .OwnsOne(x => x.Telefono)
                .Property(x => x.Value)
                .IsRequired();

            builder
                .OwnsOne(x => x.Correo)
                .Property(x => x.Value)
                .IsRequired();
        }
    }
}
