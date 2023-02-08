using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myERP.Core.Entities;

namespace myERP.Data.contexts.configurations
{
    public class CineOfertaConfiguration : IEntityTypeConfiguration<CineOferta>
    {
        public void Configure(EntityTypeBuilder<CineOferta> builder)
        {
            builder.Property(prop => prop.PorcentajeDescuento)
                .HasPrecision(precision: 5, scale: 2);

            //builder.Property(prop=>prop.FechaInicio)
            //    .HasColumnType("Date");


        }
    }
}
