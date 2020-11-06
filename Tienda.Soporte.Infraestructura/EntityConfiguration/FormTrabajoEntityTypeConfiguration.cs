using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    public class FormTrabajoEntityTypeConfiguration : IEntityTypeConfiguration<FormTrabajo>
    {
        public void Configure(EntityTypeBuilder<FormTrabajo> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("formTrabajoId");

            builder
                .Property(x => x.TrabajoRealizado)
                .IsRequired();

            builder
                .Property(x => x.FechaForm)
                .IsRequired();

            builder
                .Property(x => x.ClienteConfirma)
                .IsRequired();


        }
    }
}
