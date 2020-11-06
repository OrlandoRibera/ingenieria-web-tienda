using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    public class CitaTecnicoEntityTypeConfiguration : IEntityTypeConfiguration<CitaTecnico>
    {
        public void Configure(EntityTypeBuilder<CitaTecnico> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("citatecnicoId");
        }
    }
}
