using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    public class CitaEntityTypeConfiguration : IEntityTypeConfiguration<Cita>
    {
        public void Configure(EntityTypeBuilder<Cita> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("citaId");

            builder
                .Property(x => x.FechaPrevista)
                .IsRequired();

            builder
                .Property(x => x.Direccion)
                .IsRequired();

            builder
                .Property(x => x.Descripcion)
                .IsRequired();
        }
    }
}
