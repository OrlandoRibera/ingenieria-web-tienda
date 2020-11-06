using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    class SoporteProductoTypeConfiguration : IEntityTypeConfiguration<SoporteProducto>
    {
        public void Configure(EntityTypeBuilder<SoporteProducto> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("soporteProductoId");
        }
    }
}

