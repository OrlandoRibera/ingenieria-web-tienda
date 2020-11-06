using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    public class SoporteEntityTypeConfiguration : IEntityTypeConfiguration<Domain.Model.Soporte.Soporte>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Model.Soporte.Soporte> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("soporteId");

            builder
                .OwnsOne(x => x.Descripcion)
                .Property(x => x.Value)
                .HasColumnName("descripcion")
                .IsRequired();

            builder
                .Property(x => x.Costo)
                .HasColumnName("costo")
                .IsRequired();

            builder
               .Property(x => x.Estado)
               .HasColumnName("estado")
               .IsRequired();

            builder
                .Property(x => x.FechaCreacion)
                .HasColumnName("fechaCreacion")
                .IsRequired();

            builder
                .Property(x => x.FechaCulminacion)
                .HasColumnName("fechaCulminacion");

            builder
                .Property(x => x.FechaAnulacion)
                .HasColumnName("fechaAnulacion");
        }
    }
}
